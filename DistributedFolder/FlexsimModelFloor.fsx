<?xml version="1.0" encoding="UTF-8"?>
<flexsim-tree version="4" treetype="distributed">
<node f="62" dt="4"><name>FlexsimModelFloor</name><data>
 <node f="40"><name></name></node>
 <node f="42"><name>classes</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>VisualTool</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>superclasses</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>FlexSimObject</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>variables</name>
  <node f="80000040"><name></name></node>
  <node f="42" dt="1"><name>shapetypes</name><data>0000000040200000</data></node>
  <node f="42" dt="1"><name>divisions</name><data>000000003ff00000</data></node>
  <node f="42"><name>repeatx</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
  </node>
  <node f="42"><name>repeaty</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
  </node>
  <node f="42" dt="1"><name>nroftexts</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>settextloc</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>containercontent</name><data>0000000000000000</data></node>
  <node f="442" dt="2"><name>objectref</name><data>Object current = ownerobject(c);
/**Port by Expression*/
/** \nCenter port number: */
int portnum = /**/1/**/;
/** \n\nNote: The expression may be a constant value or the result of a command (item.Type, item.labelName, duniform(1,2), etc).*/

return centerobject(current,portnum);</data></node>
  <node f="442" dt="2"><name>textcode</name><data>Object current = ownerobject(c);
treenode  textnode = parnode(1);
/***popup:DisplayText*/
/**Display Text*/

/** \nText: */
string text = /***tag:text*//**/"Hello"/**/;

setnodestr(textnode,text);

return 1;</data></node>
  <node f="42" dt="2"><name>textnode</name><data>Hello</data></node>
  <node f="42" dt="1"><name>textsize</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>viewmagnification</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>viewdistance</name><data>00000000408f4000</data></node>
  <node f="42" dt="1"><name>textthickness</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>billboardtype</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>showcontents</name><data>000000003ff00000</data></node>
  <node f="42" dt="2"><name>connectinputs</name><data></data></node>
  <node f="42" dt="2"><name>connectoutputs</name><data></data></node>
  <node f="42" dt="2"><name>messagetrigger</name><data>Object current = ownerobject(c);
</data>
   <node f="40"><name></name></node></node>
  <node f="42" dt="2"><name>ondrawtrigger</name><data>Object current = ownerobject(c);
treenode view = parnode(1);

// If this function returns a true, the default draw code of the object will not be executed.
</data></node>
  <node f="42"><name>timetables</name></node>
  <node f="42"><name>networknodes</name></node>
  <node f="42" dt="1"><name>timeoflaststop</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>nrofstops</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>statebeforestop</name><data>0000000000000000</data></node>
  <node f="42"><name>collisionspheres</name></node>
  <node f="42"><name>collisionobjects</name></node>
  <node f="42" dt="2"><name>resettrigger</name><data>Object current = ownerobject(c);
</data></node>
  <node f="42" dt="1"><name>savedstate</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>resetposition</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>doanimations</name><data>000000003ff00000</data></node>
  <node f="42"><name>snapPoints</name></node>
  <node f="42" dt="1"><name>snapDrawMode</name><data>0000000000000000</data>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name>snapDrawSize</name><data>0000000000000000</data></node>
  </node>
  <node f="42" dt="1"><name>snapDrawSize</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>polygonOffsetFactor</name><data>0000000040100000</data></node>
  <node f="42" dt="1"><name>polygonOffsetUnits</name><data>0000000040260000</data></node>
 </node>
 <node f="42"><name>visual</name>
  <node f="40"><name></name></node>
  <node f="42"><name>color</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name>red</name><data>dfdfdfe03fdfdfdf</data></node>
   <node f="42" dt="1"><name>green</name><data>dfdfdfe03fdfdfdf</data></node>
   <node f="42" dt="1"><name>blue</name><data>dfdfdfe03fdfdfdf</data></node>
  </node>
  <node f="42" dt="2"><name>shape</name><data></data></node>
  <node f="42" dt="1"><name>shapeindex</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>picture</name><data>bitmaps\floor.png</data></node>
  <node f="42" dt="2"><name>imageobject</name><data></data></node>
  <node f="42" dt="1"><name>imageindexobject</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imagebase</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexbase</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>drawflags</name><data>0000000000000000</data></node>
 </node>
 <node f="42"><name>special</name>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>title</name><data>FlexSim Model Floor</data></node>
  <node f="42" dt="2"><name>description</name><data></data></node>
  <node f="42" dt="2"><name>guifocusclass</name><data>VIEW:/pages/tools/FloorParameters</data></node>
  <node f="42" dt="2"><name>tooltip</name><data>A floor plane that extends as far as the eye can see.</data></node>
 </node>
 <node f="42"><name>spatial</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>spatialx</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>0000000040100000</data></node>
  <node f="42" dt="1"><name>spatialz</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialsx</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>spatialsy</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>spatialsz</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>spatialrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialrz</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsety</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetz</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetsx</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>offsetsy</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>offsetsz</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>offsetrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetrz</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>centroid</name><data>000000003ff00000</data></node>
 </node>
 <node f="42"><name>stored</name></node>
</data></node></flexsim-tree>
