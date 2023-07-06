from operator import truediv
import os
import xml.etree.ElementTree as ET

##################################################################################################################################################

# INPUT FILE PATH TO PROJECT FOLDER HERE IN QUOTATION MARKS

main_file_path = "C:/Users/A2LC_Guest/Downloads/ScriptTesting"

# INPUT FILE NAME HERE IN QUOTATION MARKS

main_fsx_name = "Tester.fsx"
main_ffm_name = "Tester.ffm"

# INPUT DESIRED FOLDERS TO EXTRACT HERE IN QUOTATION MARKS

file_names_list = ["ProcessFlow", "flypath"]

# INPUT NAME OF HIGHEST RANKED OBJECT IN EACH SPLIT GROUP HERE IN QUOTATION MARKS

intv_obj_list = ["DefaultNetworkNavigator", "Departure 1", "Wall 1"]

##################################################################################################################################################

# code extracts list of items in model tree
# split objects based on given num of groups
# splits objects in each group into smaller groups to go below 25mb github limit

##################################################################################################################################################

#name of subfolder
repo_name = "DistributedFolder" 

if repo_name in os.listdir(main_file_path):
	pass
else:
	os.mkdir(main_file_path + "/" + repo_name)

# distribute objects

main_fsx = main_file_path + "/" + main_fsx_name
main_ffm = main_file_path + "/" + main_ffm_name

# function read_XML() currently extracts Flexsim object names from .fsx file and compiles them into a linear list with no change to the order

def read_XML(fsx_name):

	file_data = ET.parse(fsx_name)
	str_data = file_data.getroot()

	for child in str_data.findall(".//node"):
		if 'dt' in list(child.attrib.keys()):
			if child.attrib['dt'] == '4':
				obj = child.find('.//name').text
				tree_list.append(obj)

				# to test output
				#print(child.attrib, child.find('.//name').text)

def create_XML(ffm_name, ffm_text_list):
	with open(ffm_name, "w") as f:
		for line in ffm_text_list:
			f.write(line)
			f.write("\n")
#		print("test")

#################################################################################################################################################

ffm_text_list = []

ffm_text_list.append('<?xml version="1.0" encoding="utf-8"?>') # to print required parsing information for .ffm file
ffm_text_list.append('<flexsim-file-map version="1">')

# extract desired folders

for file in file_names_list:
	ffm_text_list.append('    ' + '<map-node path="/Tools/{}" file="{}\{}.fsx" file-map-method="single-node"/>'.format(file, repo_name, file))

# group remaining folders and separate from objects

ffm_text_list.append('    ' + '<map-node path="" file="{}\misc.fsx" file-map-method="split-points">'.format(repo_name))

#################################################################################################################################################

#ffm_text_list.append('    ' + '<map-node path="/Tools/Workspace" file="{}\Workspace.fsx" file-map-method="single-node"/>'.format(repo_name)) #file for non-object items

#tree_list = ["Source 1", "Source 2", "Queue1", "Source 3", "Queue2", "Conveyer1", "Queue3"] #dummy sorted list
tree_list = []
info_list = []
reject_list = []
num_check = False
obj_check = False

read_XML(main_fsx)

# removes non-objects in list
sec_num = tree_list.index(intv_obj_list[0])
info_list = tree_list[sec_num:]
						
# to ensure all objects accounted for
#print(info_list)

split_num = ""

for i in range(len(info_list)):
	object = info_list[i]

	if object in intv_obj_list:
		split_num = str(intv_obj_list.index(object))
	
	if i%10 == 0:
		ffm_text_list.append('        ' + '<split-point name="{1}" file="{0}\{2}_{1}.fsx"/>'.format(repo_name, object, split_num))

ffm_text_list.append('    ' + '</map-node>')
ffm_text_list.append('</flexsim-file-map>')

# to test output
#print(ffm_text_list)

create_XML(main_ffm, ffm_text_list)