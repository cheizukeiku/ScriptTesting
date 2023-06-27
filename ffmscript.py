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

# INPUT NAME OF HIGHEST RANKED OBJECT HERE IN QUOTATION MARKS

first_obj = "DefaultNetworkNavigator"

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

ffm_text_list.append('    ' + '<map-node path="" file="{}\misc.fsx" file-map-method="split-points"/>'.format(repo_name))

#################################################################################################################################################

#ffm_text_list.append('    ' + '<map-node path="/Tools/Workspace" file="{}\Workspace.fsx" file-map-method="single-node"/>'.format(repo_name)) #file for non-object items

#tree_list = ["Source 1", "Source 2", "Queue1", "Source 3", "Queue2", "Conveyer1", "Queue3"] #dummy sorted list
tree_list = []
info_list = {}
reject_list = []
num_check = False

read_XML(main_fsx)

for i in tree_list:
		
	compar = ""
			
	for m in i:
		if m.isalpha() or m == " ":
			compar += m
		elif m.isdigit():
			num_check = True

	if num_check == True:
		compar += "1"


	if compar in list(info_list.keys()):
		info_list[compar] += 1

	else:
		info_list[compar] = 1

	num_check = False
						
# to test output
#print(info_list)

info_keys = list(info_list.keys())
info_values = list(info_list.values())

for i in range(len(info_keys)):
	object = info_keys[i]
	object_name = object

	if object[-1].isdigit():
		object_name = object[:-1].strip()
		
	if i == 0:
		ffm_text_list.append('        ' + '<split-point="{2}" file="{0}\{1}.fsx" file-map-method="split-points"/>'.format(repo_name, first_obj, first_obj))
	else:
		ffm_text_list.append('        ' + '<split-point name="{2}" file="{0}\{1}.fsx"/>'.format(repo_name, object_name, object))

ffm_text_list.append('    ' + '</map-node>')
ffm_text_list.append('</flexsim-file-map>')

# to test output
#print(ffm_text_list)

create_XML(main_ffm, ffm_text_list)