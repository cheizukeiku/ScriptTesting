<?xml version="1.0" encoding="UTF-8"?>
<flexsim-tree version="4" treetype="distributed">
<node f="62" dt="4"><name>ExitTransfer2</name><data>
 <node f="40"><name></name></node>
 <node f="42"><name>classes</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Conveyor::ExitTransfer</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>superclasses</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Conveyor::FRTransfer</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>variables</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>stopAtEnd</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>continuousPickPrediction</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>ignoreOnPredictLatePickup</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>pickPredictionInterval</name><data>000000003ff00000</data></node>
  <node f="42"><name>transferPoint</name>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name></name><data><coupling>/StraightConveyor4&gt;variables/conveyorPoints/_3</coupling></data></node>
  </node>
  <node f="42" dt="1"><name>canOrphan</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>nrreleased</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>pull</name><data>0000000000000000</data></node>
  <node f="8000000442" dt="2"><name>sendtoport</name><data>Object item = param(1);
Object current = ownerobject(c);
/**First available*/

return 0 ;</data></node>
  <node f="8000000442" dt="2"><name>receivefromport</name><data>Object current = ownerobject(c);
/**Any Port*/
return 0;
</data></node>
  <node f="8000000442" dt="2"><name>pullrequirement</name><data>Object current = ownerobject(c);
Object item = param(1);
int port =  param(2);

/**Pull Anything*/

return 1;</data></node>
  <node f="42" dt="1"><name>usetransport</name><data>0000000000000000</data>
   <node f="40"><name></name></node></node>
  <node f="42" dt="1"><name>transportpriority</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>preempttransport</name><data>0000000000000000</data></node>
  <node f="442" dt="2"><name>transportdispatcher</name><data>Object current = ownerobject(c);
Object item = param(1);
int port = param(2);
Object destination = param(3);
double priority = param(4);
int preempt = param(5);

/***popup:CenterObject*/
return /**/current.centerObjects[/**/
	/***tag:portnr*//**/1/**//**/]/**/;
</data></node>
  <node f="42" dt="1"><name>nroftransportsout</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>nroftransportsin</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>outwaitinfo</name><data>0000000000000000</data>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
  </node>
  <node f="42" dt="1"><name>sendtocontinuous</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>pullcontinuous</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>lifo</name><data>0000000000000000</data></node>
  <node f="42"><name>timetables</name></node>
  <node f="42"><name>networknodes</name></node>
  <node f="42" dt="1"><name>timeoflaststop</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>nrofstops</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>statebeforestop</name><data>0000000000000000</data></node>
  <node f="42"><name>collisionspheres</name></node>
  <node f="42"><name>collisionobjects</name></node>
  <node f="42" dt="1"><name>savedstate</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>resetposition</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>doanimations</name><data>000000003ff00000</data></node>
 </node>
 <node f="42"><name>behaviour</name>
  <node f="40"><name></name></node></node>
 <node f="42"><name>special</name>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>description</name><data></data></node>
  <node f="42" dt="2"><name>guifocusclass</name><data>VIEW:/standardviews/modelingutilities/QuickerProperties</data></node>
  <node f="42" dt="2"><name>title</name><data>Fixed Resource Multiservice</data></node>
 </node>
 <node f="4000000042" dt="2"><name>windowtitle</name><data>ExitTransfer</data>
  <node f="40"><name></name></node></node>
 <node f="42"><name>objectinfo</name></node>
 <node f="42"><name>visual</name>
  <node f="40"><name></name></node>
  <node f="42"><name>color</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name>red</name><data>333333333fe33333</data></node>
   <node f="42" dt="1"><name>green</name><data>333333333fe33333</data></node>
   <node f="42" dt="1"><name>blue</name><data>0000000000000000</data></node>
  </node>
  <node f="42" dt="2"><name>shape</name><data>***</data></node>
  <node f="42" dt="1"><name>shapeindex</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imageobject</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexobject</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imagebase</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexbase</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>picture</name><data>bitmaps\Template.bmp</data></node>
 </node>
 <node f="42"><name>spatial</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>spatialx</name><data>f3a6670fc004b88c</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>fa264199c03bd119</data></node>
  <node f="42" dt="1"><name>spatialz</name><data>00000000bfe00000</data></node>
  <node f="42" dt="1"><name>spatialsx</name><data>9999999a3fc99999</data></node>
  <node f="42" dt="1"><name>spatialsy</name><data>9999999a3fc99999</data></node>
  <node f="42" dt="1"><name>spatialsz</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>spatialrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialrz</name><data>00000000c0568000</data></node>
  <node f="42" dt="1"><name>centroid</name><data>000000003ff00000</data></node>
 </node>
 <node f="42"><name>stats</name>
  <node f="40"><name></name></node>
  <node f="42" dt="7"><name>state_current</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="6"><name>profile</name><data f="1">
    <fields>
     <field name="state" bytesize="36" type="259"/>
     <field name="time" bytesize="8" type="1"/>
     <field name="active" bytesize="4" type="2"/>
    </fields>
    <entry><ed>other</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>idle</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>processing</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>busy</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>blocked</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>generating</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>empty</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>collecting</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>releasing</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>waiting for operator</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>waiting for transport</ed><ed>0000000000000000</ed><ed>1</ed></entry></data></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040100000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_input</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040000000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_output</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040000000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_content</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulative</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulativeTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>minValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>maxValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>numEntries</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>lastSetTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>rate</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>lastResetTime</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_staytime</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040080000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="1"><name>stats_creationtime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>stats_lastmovetime</name><data>0000000000000000</data></node>
  <node f="42" dt="3"><name>releasedItems</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>labels</name>
  <node f="40"><name></name></node></node>
 <node f="42"><name>connections</name>
  <node f="40"><name></name></node>
  <node f="42"><name>connectionsin</name>
   <node f="40"><name></name></node></node>
  <node f="42"><name>connectionsout</name>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name></name><data><coupling>/Luggage Out 1&gt;connections/connectionsin/1</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
    <node f="42" dt="3"><name></name><data><coupling>null</coupling></data></node>
   </node>
  </node>
  <node f="42"><name>connectionscenter</name>
   <node f="40"><name></name></node></node>
 </node>
 <node f="42"><name>events</name>
  <node f="40"><name></name></node></node>
 <node f="42" dt="7"><name>resetvalues</name><data/>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>sdt::attributetree</name><data>ObjectResetValues</data>
   <node f="40"><name></name></node></node>
 </node>
 <node f="42"><name>stored</name></node>
 <node f="42"><name>Groups</name>
  <node f="40"><name></name></node>
  <node f="810000042" dt="3"><name></name><data><coupling>/Tools/Groups/ExitTransfers/_1</coupling></data></node>
 </node>
</data></node>
<node f="62" dt="4"><name>EntryTransfer3</name><data>
 <node f="40"><name></name></node>
 <node f="42"><name>classes</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Conveyor::EntryTransfer</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>superclasses</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Conveyor::FRTransfer</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>variables</name>
  <node f="40"><name></name></node>
  <node f="442" dt="2"><name>entryOrientation</name><data>Object current = ownerobject(c);
Conveyor conveyor = param(1);
Object item = param(2);
Conveyor.Item conveyorItem = conveyor.itemData[item];

/***popup:Conveyor_FixedOrientation*/
/***tag:description*//**Forward: Z+, Up: Y+*/
/** \nForward: *//***tag:forwardAxis*//**Z+*/
/** \nUp: *//***tag:upAxis*//**Y+*/
return /** \nOrientation: *//***tag:orientation*//**/CONV_ITEM_Z_BY_X/**/;
</data></node>
  <node f="42" dt="1"><name>itemInsertionMode</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>holdTransports</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>maxTransportsIn</name><data>0000000000000000</data></node>
  <node f="42"><name>transferPoint</name>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name></name><data><coupling>/StraightConveyor2&gt;variables/conveyorPoints/_1</coupling></data></node>
  </node>
  <node f="42" dt="1"><name>canOrphan</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>nrreleased</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>pull</name><data>0000000000000000</data></node>
  <node f="8000000442" dt="2"><name>sendtoport</name><data>Object item = param(1);
Object current = ownerobject(c);
/**First available*/

return 0 ;</data></node>
  <node f="8000000442" dt="2"><name>receivefromport</name><data>Object current = ownerobject(c);
/**Any Port*/
return 0;
</data></node>
  <node f="8000000442" dt="2"><name>pullrequirement</name><data>Object current = ownerobject(c);
Object item = param(1);
int port =  param(2);

/**Pull Anything*/

return 1;</data></node>
  <node f="42" dt="1"><name>usetransport</name><data>0000000000000000</data>
   <node f="40"><name></name></node></node>
  <node f="42" dt="1"><name>transportpriority</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>preempttransport</name><data>0000000000000000</data></node>
  <node f="442" dt="2"><name>transportdispatcher</name><data>Object current = ownerobject(c);
Object item = param(1);
int port = param(2);
Object destination = param(3);
double priority = param(4);
int preempt = param(5);

/***popup:CenterObject*/
return /**/current.centerObjects[/**/
	/***tag:portnr*//**/1/**//**/]/**/;
</data></node>
  <node f="42" dt="1"><name>nroftransportsout</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>nroftransportsin</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>outwaitinfo</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>sendtocontinuous</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>pullcontinuous</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>lifo</name><data>0000000000000000</data></node>
  <node f="42"><name>timetables</name></node>
  <node f="42"><name>networknodes</name></node>
  <node f="42" dt="1"><name>timeoflaststop</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>nrofstops</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>statebeforestop</name><data>0000000000000000</data></node>
  <node f="42"><name>collisionspheres</name></node>
  <node f="42"><name>collisionobjects</name></node>
  <node f="42" dt="1"><name>savedstate</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>resetposition</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>doanimations</name><data>000000003ff00000</data></node>
  <node f="42" dt="7"><name>blockedUpstreamTraversalMap</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>Conveyor::EntryTransfer::BlockedUpstreamTraversalMap</data>
    <node f="40"><name></name></node></node>
  </node>
  <node f="42" dt="1"><name>pullFromPort</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>pullRequirement</name><data>0000000000000000</data></node>
 </node>
 <node f="42"><name>behaviour</name>
  <node f="40"><name></name></node></node>
 <node f="42"><name>special</name>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>description</name><data></data></node>
  <node f="42" dt="2"><name>guifocusclass</name><data>VIEW:/standardviews/modelingutilities/QuickerProperties</data></node>
  <node f="42" dt="2"><name>title</name><data>Fixed Resource Multiservice</data></node>
 </node>
 <node f="4000000042" dt="2"><name>windowtitle</name><data>EntryTransfer</data>
  <node f="40"><name></name></node></node>
 <node f="42"><name>objectinfo</name></node>
 <node f="42"><name>visual</name>
  <node f="40"><name></name></node>
  <node f="42"><name>color</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name>red</name><data>333333333fe33333</data></node>
   <node f="42" dt="1"><name>green</name><data>333333333fe33333</data></node>
   <node f="42" dt="1"><name>blue</name><data>0000000000000000</data></node>
  </node>
  <node f="42" dt="2"><name>shape</name><data>***</data></node>
  <node f="42" dt="1"><name>shapeindex</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imageobject</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexobject</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imagebase</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexbase</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>picture</name><data>bitmaps\Template.bmp</data></node>
 </node>
 <node f="42"><name>spatial</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>spatialx</name><data>2978efca3fff7b03</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>94f889e7c024cc23</data></node>
  <node f="42" dt="1"><name>spatialz</name><data>00000000bfe00000</data></node>
  <node f="42" dt="1"><name>spatialsx</name><data>9999999a3fc99999</data></node>
  <node f="42" dt="1"><name>spatialsy</name><data>9999999a3fc99999</data></node>
  <node f="42" dt="1"><name>spatialsz</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>spatialrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialrz</name><data>0000000040668000</data></node>
  <node f="42" dt="1"><name>centroid</name><data>000000003ff00000</data></node>
 </node>
 <node f="42"><name>stats</name>
  <node f="40"><name></name></node>
  <node f="42" dt="7"><name>state_current</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="6"><name>profile</name><data f="1">
    <fields>
     <field name="state" bytesize="36" type="259"/>
     <field name="time" bytesize="8" type="1"/>
     <field name="active" bytesize="4" type="2"/>
    </fields>
    <entry><ed>other</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>idle</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>processing</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>busy</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>blocked</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>generating</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>empty</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>collecting</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>releasing</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>waiting for operator</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>waiting for transport</ed><ed>0000000000000000</ed><ed>1</ed></entry></data></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040100000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_input</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040000000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_output</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040000000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_content</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulative</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulativeTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>minValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>maxValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>numEntries</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>lastSetTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>rate</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>lastResetTime</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_staytime</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040080000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="1"><name>stats_creationtime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>stats_lastmovetime</name><data>0000000000000000</data></node>
  <node f="42" dt="3"><name>releasedItems</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="1"><name>receivePort</name><data>00000000c0000000</data></node>
 </node>
 <node f="42"><name>labels</name>
  <node f="40"><name></name></node></node>
 <node f="42"><name>connections</name>
  <node f="40"><name></name></node>
  <node f="42"><name>connectionsin</name>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name></name><data><coupling>/Bag Drop 1&gt;connections/connectionsout/1</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
    <node f="42" dt="3"><name></name><data><coupling>null</coupling></data></node>
   </node>
  </node>
  <node f="42"><name>connectionsout</name>
   <node f="40"><name></name></node></node>
  <node f="42"><name>connectionscenter</name>
   <node f="40"><name></name></node></node>
 </node>
 <node f="42"><name>events</name>
  <node f="40"><name></name></node></node>
 <node f="42" dt="7"><name>resetvalues</name><data/>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>sdt::attributetree</name><data>ObjectResetValues</data>
   <node f="40"><name></name></node></node>
 </node>
 <node f="42"><name>stored</name></node>
 <node f="42"><name>Groups</name>
  <node f="40"><name></name></node>
  <node f="810000042" dt="3"><name></name><data><coupling>/Tools/Groups/EntryTransfers/_3</coupling></data></node>
 </node>
</data>
 <node f="40"><name></name></node></node>
<node f="62" dt="4"><name>EntryTransfer4</name><data>
 <node f="40"><name></name></node>
 <node f="42"><name>classes</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Conveyor::EntryTransfer</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>superclasses</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Conveyor::FRTransfer</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>variables</name>
  <node f="40"><name></name></node>
  <node f="442" dt="2"><name>entryOrientation</name><data>Object current = ownerobject(c);
Conveyor conveyor = param(1);
Object item = param(2);
Conveyor.Item conveyorItem = conveyor.itemData[item];

/***popup:Conveyor_FixedOrientation*/
/***tag:description*//**Forward: Z+, Up: Y+*/
/** \nForward: *//***tag:forwardAxis*//**Z+*/
/** \nUp: *//***tag:upAxis*//**Y+*/
return /** \nOrientation: *//***tag:orientation*//**/CONV_ITEM_Z_BY_X/**/;
</data></node>
  <node f="42" dt="1"><name>itemInsertionMode</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>holdTransports</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>maxTransportsIn</name><data>0000000000000000</data></node>
  <node f="42"><name>transferPoint</name>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name></name><data><coupling>/StraightConveyor3&gt;variables/conveyorPoints/_1</coupling></data></node>
  </node>
  <node f="42" dt="1"><name>canOrphan</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>nrreleased</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>pull</name><data>0000000000000000</data></node>
  <node f="8000000442" dt="2"><name>sendtoport</name><data>Object item = param(1);
Object current = ownerobject(c);
/**First available*/

return 0 ;</data></node>
  <node f="8000000442" dt="2"><name>receivefromport</name><data>Object current = ownerobject(c);
/**Any Port*/
return 0;
</data></node>
  <node f="8000000442" dt="2"><name>pullrequirement</name><data>Object current = ownerobject(c);
Object item = param(1);
int port =  param(2);

/**Pull Anything*/

return 1;</data></node>
  <node f="42" dt="1"><name>usetransport</name><data>0000000000000000</data>
   <node f="40"><name></name></node></node>
  <node f="42" dt="1"><name>transportpriority</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>preempttransport</name><data>0000000000000000</data></node>
  <node f="442" dt="2"><name>transportdispatcher</name><data>Object current = ownerobject(c);
Object item = param(1);
int port = param(2);
Object destination = param(3);
double priority = param(4);
int preempt = param(5);

/***popup:CenterObject*/
return /**/current.centerObjects[/**/
	/***tag:portnr*//**/1/**//**/]/**/;
</data></node>
  <node f="42" dt="1"><name>nroftransportsout</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>nroftransportsin</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>outwaitinfo</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>sendtocontinuous</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>pullcontinuous</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>lifo</name><data>0000000000000000</data></node>
  <node f="42"><name>timetables</name></node>
  <node f="42"><name>networknodes</name></node>
  <node f="42" dt="1"><name>timeoflaststop</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>nrofstops</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>statebeforestop</name><data>0000000000000000</data></node>
  <node f="42"><name>collisionspheres</name></node>
  <node f="42"><name>collisionobjects</name></node>
  <node f="42" dt="1"><name>savedstate</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>resetposition</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>doanimations</name><data>000000003ff00000</data></node>
  <node f="42" dt="7"><name>blockedUpstreamTraversalMap</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>Conveyor::EntryTransfer::BlockedUpstreamTraversalMap</data>
    <node f="40"><name></name></node></node>
  </node>
  <node f="42" dt="1"><name>pullFromPort</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>pullRequirement</name><data>0000000000000000</data></node>
 </node>
 <node f="42"><name>behaviour</name>
  <node f="40"><name></name></node></node>
 <node f="42"><name>special</name>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>description</name><data></data></node>
  <node f="42" dt="2"><name>guifocusclass</name><data>VIEW:/standardviews/modelingutilities/QuickerProperties</data></node>
  <node f="42" dt="2"><name>title</name><data>Fixed Resource Multiservice</data></node>
 </node>
 <node f="4000000042" dt="2"><name>windowtitle</name><data>EntryTransfer</data>
  <node f="40"><name></name></node></node>
 <node f="42"><name>objectinfo</name></node>
 <node f="42"><name>visual</name>
  <node f="40"><name></name></node>
  <node f="42"><name>color</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name>red</name><data>333333333fe33333</data></node>
   <node f="42" dt="1"><name>green</name><data>333333333fe33333</data></node>
   <node f="42" dt="1"><name>blue</name><data>0000000000000000</data></node>
  </node>
  <node f="42" dt="2"><name>shape</name><data>***</data></node>
  <node f="42" dt="1"><name>shapeindex</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imageobject</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexobject</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imagebase</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexbase</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>picture</name><data>bitmaps\Template.bmp</data></node>
 </node>
 <node f="42"><name>spatial</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>spatialx</name><data>fbe1a6583fffc930</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>bfae1940c02ae3d2</data></node>
  <node f="42" dt="1"><name>spatialz</name><data>00000000bfe00000</data></node>
  <node f="42" dt="1"><name>spatialsx</name><data>9999999a3fc99999</data></node>
  <node f="42" dt="1"><name>spatialsy</name><data>9999999a3fc99999</data></node>
  <node f="42" dt="1"><name>spatialsz</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>spatialrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialrz</name><data>0000000040668000</data></node>
  <node f="42" dt="1"><name>centroid</name><data>000000003ff00000</data></node>
 </node>
 <node f="42"><name>stats</name>
  <node f="40"><name></name></node>
  <node f="42" dt="7"><name>state_current</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="6"><name>profile</name><data f="1">
    <fields>
     <field name="state" bytesize="36" type="259"/>
     <field name="time" bytesize="8" type="1"/>
     <field name="active" bytesize="4" type="2"/>
    </fields>
    <entry><ed>other</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>idle</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>processing</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>busy</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>blocked</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>generating</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>empty</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>collecting</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>releasing</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>waiting for operator</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>waiting for transport</ed><ed>0000000000000000</ed><ed>1</ed></entry></data></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040100000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_input</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040000000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_output</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040000000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_content</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulative</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulativeTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>minValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>maxValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>numEntries</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>lastSetTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>rate</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>lastResetTime</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_staytime</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040080000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="1"><name>stats_creationtime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>stats_lastmovetime</name><data>0000000000000000</data></node>
  <node f="42" dt="3"><name>releasedItems</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="1"><name>receivePort</name><data>00000000c0000000</data></node>
 </node>
 <node f="42"><name>labels</name>
  <node f="40"><name></name></node></node>
 <node f="42"><name>connections</name>
  <node f="40"><name></name></node>
  <node f="42"><name>connectionsin</name>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name></name><data><coupling>/Bag Drop 2&gt;connections/connectionsout/1</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
    <node f="42" dt="3"><name></name><data><coupling>null</coupling></data></node>
   </node>
  </node>
  <node f="42"><name>connectionsout</name>
   <node f="40"><name></name></node></node>
  <node f="42"><name>connectionscenter</name>
   <node f="40"><name></name></node></node>
 </node>
 <node f="42"><name>events</name>
  <node f="40"><name></name></node></node>
 <node f="42" dt="7"><name>resetvalues</name><data/>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>sdt::attributetree</name><data>ObjectResetValues</data>
   <node f="40"><name></name></node></node>
 </node>
 <node f="42"><name>stored</name></node>
 <node f="42"><name>Groups</name>
  <node f="40"><name></name></node>
  <node f="810000042" dt="3"><name></name><data><coupling>/Tools/Groups/EntryTransfers/_4</coupling></data></node>
 </node>
</data>
 <node f="40"><name></name></node></node>
<node f="20042" dt="4"><name>Bag Drop 4</name><data>
 <node f="40"><name></name></node>
 <node f="42"><name>superclasses</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>FixedResource</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>classes</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Queue</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>variables</name>
  <node f="80000040"><name></name></node>
  <node f="42" dt="1"><name>maxcontent</name><data>00000000408f4000</data>
   <node f="40"><name></name></node></node>
  <node f="42" dt="1"><name>usebatching</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>batchsize</name><data>0000000040000000</data></node>
  <node f="42" dt="1"><name>maxwaittime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>flush</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>currentbatchsize</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>placemode</name><data>0000000040080000</data></node>
  <node f="42" dt="1"><name>stackinitz</name><data>9999999a3fb99999</data></node>
  <node f="42" dt="1"><name>nrreleased</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>pull</name><data>0000000000000000</data></node>
  <node f="8000000442" dt="2"><name>sendtoport</name><data>Object item = param(1);
Object current = ownerobject(c);
/**First available*/

return 0 ;</data></node>
  <node f="8000000442" dt="2"><name>receivefromport</name><data>Object current = ownerobject(c);
/**Any Port*/
return 0;
</data></node>
  <node f="8000000442" dt="2"><name>pullrequirement</name><data>Object current = ownerobject(c);
Object item = param(1);
int port =  param(2);

/**Pull Anything*/

return 1;</data></node>
  <node f="42" dt="1"><name>usetransport</name><data>0000000000000000</data>
   <node f="40"><name></name></node></node>
  <node f="42" dt="1"><name>transportpriority</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>preempttransport</name><data>0000000000000000</data></node>
  <node f="442" dt="2"><name>transportdispatcher</name><data>Object current = ownerobject(c);
Object item = param(1);
int port = param(2);
Object destination = param(3);
double priority = param(4);
int preempt = param(5);

/***popup:CenterObject*/
return /**/current.centerObjects[/**/
	/***tag:portnr*//**/1/**//**/]/**/;
</data></node>
  <node f="42" dt="1"><name>nroftransportsout</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>nroftransportsin</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>outwaitinfo</name><data>0000000000000000</data>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
  </node>
  <node f="42" dt="1"><name>sendtocontinuous</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>pullcontinuous</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>lifo</name><data>0000000000000000</data></node>
  <node f="42"><name>timetables</name></node>
  <node f="42"><name>networknodes</name>
   <node f="40"><name></name></node></node>
  <node f="42" dt="1"><name>timeoflaststop</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>nrofstops</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>statebeforestop</name><data>0000000000000000</data></node>
  <node f="42"><name>collisionspheres</name></node>
  <node f="42"><name>collisionobjects</name></node>
  <node f="42" dt="1"><name>savedstate</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>resetposition</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>doanimations</name><data>000000003ff00000</data></node>
 </node>
 <node f="42"><name>behaviour</name>
  <node f="40"><name></name></node></node>
 <node f="42"><name>stats</name>
  <node f="40"><name></name></node>
  <node f="42" dt="7"><name>state_current</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="6"><name>profile</name><data f="1">
    <fields>
     <field name="state" bytesize="36" type="259"/>
     <field name="time" bytesize="8" type="1"/>
     <field name="active" bytesize="4" type="2"/>
    </fields>
    <entry><ed>other</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>idle</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>processing</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>busy</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>blocked</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>generating</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>empty</ed><ed>0000000000000000</ed><ed>1</ed></entry>
    <entry><ed>collecting</ed><ed>0000000000000000</ed><ed>1</ed></entry>
    <entry><ed>releasing</ed><ed>0000000000000000</ed><ed>1</ed></entry>
    <entry><ed>waiting for operator</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>waiting for transport</ed><ed>0000000000000000</ed><ed>1</ed></entry></data></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040100000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000040180000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulative</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulativeTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>minValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>maxValue</name><data>0000000040180000</data></node>
    <node f="42" dt="1"><name>numEntries</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>lastSetTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>rate</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>lastResetTime</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_input</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040000000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_output</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040000000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_content</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulative</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulativeTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>minValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>maxValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>numEntries</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>lastSetTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>rate</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>lastResetTime</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_staytime</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040080000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="1"><name>stats_creationtime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>stats_lastmovetime</name><data>0000000000000000</data></node>
 </node>
 <node f="42"><name>special</name>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>title</name><data>Fixed Resource Queue</data></node>
  <node f="42" dt="2"><name>description</name><data></data></node>
  <node f="42" dt="2"><name>guifocusclass</name><data>VIEW:/standardviews/modelingutilities/QuickerProperties</data></node>
  <node f="4000000042" dt="2"><name>tooltip</name><data>Queues/batches flow items</data></node>
 </node>
 <node f="42"><name>visual</name>
  <node f="40"><name></name></node>
  <node f="42"><name>color</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name>red</name><data>000000003fe00000</data></node>
   <node f="42" dt="1"><name>green</name><data>000000003fe00000</data></node>
   <node f="42" dt="1"><name>blue</name><data>000000003fe00000</data></node>
  </node>
  <node f="42" dt="2"><name>shape</name><data>fs3d\Queue\Queue.3ds</data></node>
  <node f="42" dt="1"><name>shapeindex</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>picture</name><data>bitmaps\queuepicturesmall.png</data></node>
  <node f="42" dt="2"><name>imageobject</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexobject</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imagebase</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexbase</name><data>0000000000000000</data></node>
 </node>
 <node f="42"><name>spatial</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>spatialx</name><data>00000000403e0000</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>00000000c03a0000</data></node>
  <node f="42" dt="1"><name>spatialz</name><data>00000000c0140000</data></node>
  <node f="42" dt="1"><name>spatialsx</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>spatialsy</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>spatialsz</name><data>9999999a3fb99999</data></node>
  <node f="42" dt="1"><name>spatialrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialrz</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>centroid</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>offsetx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsety</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetz</name><data>9999999a3fd99999</data></node>
  <node f="42" dt="1"><name>offsetsx</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>offsetsy</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>offsetsz</name><data>0000000040140000</data></node>
  <node f="42" dt="1"><name>offsetrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetrz</name><data>0000000000000000</data></node>
 </node>
 <node f="42"><name>objectinfo</name>
  <node f="40"><name></name></node>
  <node f="42"><name>CurContent:  0</name></node>
  <node f="42"><name>MaxContent:  0</name></node>
  <node f="42"><name>AvgStaytime: 0.0</name></node>
 </node>
 <node f="4000000042" dt="2"><name>windowtitle</name><data>Queue</data>
  <node f="40"><name></name></node></node>
 <node f="42"><name>labels</name>
  <node f="40"><name></name></node></node>
 <node f="42"><name>connections</name>
  <node f="40"><name></name></node>
  <node f="42"><name>connectionsin</name>
   <node f="40"><name></name></node></node>
  <node f="42"><name>connectionsout</name>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name></name><data><coupling>/EntryTransfer2&gt;connections/connectionsin/1</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
    <node f="42" dt="3"><name></name><data><coupling>null</coupling></data></node>
   </node>
  </node>
  <node f="42"><name>connectionscenter</name>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name>_1</name><data><coupling>/WaitingLine10&gt;connections/connectionscenter/_2</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
    <node f="42" dt="3"><name></name><data><coupling>null</coupling></data></node>
   </node>
   <node f="10000042" dt="3"><name>_2</name><data><coupling>/WaitingLine11&gt;connections/connectionscenter/_2</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
    <node f="42" dt="3"><name></name><data><coupling>null</coupling></data></node>
   </node>
   <node f="10000042" dt="3"><name>_3</name><data><coupling>/WaitingLine12&gt;connections/connectionscenter/_2</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
    <node f="42" dt="3"><name></name><data><coupling>null</coupling></data></node>
   </node>
  </node>
 </node>
 <node f="42"><name>events</name>
  <node f="40"><name></name></node></node>
 <node f="42" dt="7"><name>resetvalues</name><data/>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>sdt::attributetree</name><data>ObjectResetValues</data>
   <node f="40"><name></name></node></node>
 </node>
 <node f="42"><name>stored</name></node>
</data></node>
<node f="62" dt="4"><name>EntryTransfer2</name><data>
 <node f="40"><name></name></node>
 <node f="42"><name>classes</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Conveyor::EntryTransfer</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>superclasses</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Conveyor::FRTransfer</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>variables</name>
  <node f="40"><name></name></node>
  <node f="442" dt="2"><name>entryOrientation</name><data>Object current = ownerobject(c);
Conveyor conveyor = param(1);
Object item = param(2);
Conveyor.Item conveyorItem = conveyor.itemData[item];

/***popup:Conveyor_FixedOrientation*/
/***tag:description*//**Forward: Z+, Up: Y+*/
/** \nForward: *//***tag:forwardAxis*//**Z+*/
/** \nUp: *//***tag:upAxis*//**Y+*/
return /** \nOrientation: *//***tag:orientation*//**/CONV_ITEM_Z_BY_X/**/;
</data></node>
  <node f="42" dt="1"><name>itemInsertionMode</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>holdTransports</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>maxTransportsIn</name><data>0000000000000000</data></node>
  <node f="42"><name>transferPoint</name>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name></name><data><coupling>/StraightConveyor1&gt;variables/conveyorPoints/_2</coupling></data></node>
  </node>
  <node f="42" dt="1"><name>canOrphan</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>nrreleased</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>pull</name><data>0000000000000000</data></node>
  <node f="8000000442" dt="2"><name>sendtoport</name><data>Object item = param(1);
Object current = ownerobject(c);
/**First available*/

return 0 ;</data></node>
  <node f="8000000442" dt="2"><name>receivefromport</name><data>Object current = ownerobject(c);
/**Any Port*/
return 0;
</data></node>
  <node f="8000000442" dt="2"><name>pullrequirement</name><data>Object current = ownerobject(c);
Object item = param(1);
int port =  param(2);

/**Pull Anything*/

return 1;</data></node>
  <node f="42" dt="1"><name>usetransport</name><data>0000000000000000</data>
   <node f="40"><name></name></node></node>
  <node f="42" dt="1"><name>transportpriority</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>preempttransport</name><data>0000000000000000</data></node>
  <node f="442" dt="2"><name>transportdispatcher</name><data>Object current = ownerobject(c);
Object item = param(1);
int port = param(2);
Object destination = param(3);
double priority = param(4);
int preempt = param(5);

/***popup:CenterObject*/
return /**/current.centerObjects[/**/
	/***tag:portnr*//**/1/**//**/]/**/;
</data></node>
  <node f="42" dt="1"><name>nroftransportsout</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>nroftransportsin</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>outwaitinfo</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>sendtocontinuous</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>pullcontinuous</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>lifo</name><data>0000000000000000</data></node>
  <node f="42"><name>timetables</name></node>
  <node f="42"><name>networknodes</name></node>
  <node f="42" dt="1"><name>timeoflaststop</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>nrofstops</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>statebeforestop</name><data>0000000000000000</data></node>
  <node f="42"><name>collisionspheres</name></node>
  <node f="42"><name>collisionobjects</name></node>
  <node f="42" dt="1"><name>savedstate</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>resetposition</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>doanimations</name><data>000000003ff00000</data></node>
  <node f="42" dt="7"><name>blockedUpstreamTraversalMap</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>Conveyor::EntryTransfer::BlockedUpstreamTraversalMap</data>
    <node f="40"><name></name></node></node>
  </node>
  <node f="42" dt="1"><name>pullFromPort</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>pullRequirement</name><data>0000000000000000</data></node>
 </node>
 <node f="42"><name>behaviour</name>
  <node f="40"><name></name></node></node>
 <node f="42"><name>special</name>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>description</name><data></data></node>
  <node f="42" dt="2"><name>guifocusclass</name><data>VIEW:/standardviews/modelingutilities/QuickerProperties</data></node>
  <node f="42" dt="2"><name>title</name><data>Fixed Resource Multiservice</data></node>
 </node>
 <node f="4000000042" dt="2"><name>windowtitle</name><data>EntryTransfer</data>
  <node f="40"><name></name></node></node>
 <node f="42"><name>objectinfo</name></node>
 <node f="42"><name>visual</name>
  <node f="40"><name></name></node>
  <node f="42"><name>color</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name>red</name><data>333333333fe33333</data></node>
   <node f="42" dt="1"><name>green</name><data>333333333fe33333</data></node>
   <node f="42" dt="1"><name>blue</name><data>0000000000000000</data></node>
  </node>
  <node f="42" dt="2"><name>shape</name><data>***</data></node>
  <node f="42" dt="1"><name>shapeindex</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imageobject</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexobject</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imagebase</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexbase</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>picture</name><data>bitmaps\Template.bmp</data></node>
 </node>
 <node f="42"><name>spatial</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>spatialx</name><data>1fa63446403dc3e7</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>ccccccccc038cccc</data></node>
  <node f="42" dt="1"><name>spatialz</name><data>00000000bfe00000</data></node>
  <node f="42" dt="1"><name>spatialsx</name><data>9999999a3fc99999</data></node>
  <node f="42" dt="1"><name>spatialsy</name><data>9999999a3fc99999</data></node>
  <node f="42" dt="1"><name>spatialsz</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>spatialrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialrz</name><data>00000000c0568000</data></node>
  <node f="42" dt="1"><name>centroid</name><data>000000003ff00000</data></node>
 </node>
 <node f="42"><name>stats</name>
  <node f="40"><name></name></node>
  <node f="42" dt="7"><name>state_current</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="6"><name>profile</name><data f="1">
    <fields>
     <field name="state" bytesize="36" type="259"/>
     <field name="time" bytesize="8" type="1"/>
     <field name="active" bytesize="4" type="2"/>
    </fields>
    <entry><ed>other</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>idle</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>processing</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>busy</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>blocked</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>generating</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>empty</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>collecting</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>releasing</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>waiting for operator</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>waiting for transport</ed><ed>0000000000000000</ed><ed>1</ed></entry></data></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040100000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_input</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040000000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_output</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040000000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_content</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulative</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulativeTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>minValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>maxValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>numEntries</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>lastSetTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>rate</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>lastResetTime</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_staytime</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040080000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="1"><name>stats_creationtime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>stats_lastmovetime</name><data>0000000000000000</data></node>
  <node f="42" dt="3"><name>releasedItems</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="1"><name>receivePort</name><data>00000000c0000000</data></node>
 </node>
 <node f="42"><name>labels</name>
  <node f="40"><name></name></node></node>
 <node f="42"><name>connections</name>
  <node f="40"><name></name></node>
  <node f="42"><name>connectionsin</name>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name></name><data><coupling>/Bag Drop 4&gt;connections/connectionsout/1</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
    <node f="42" dt="3"><name></name><data><coupling>null</coupling></data></node>
   </node>
  </node>
  <node f="42"><name>connectionsout</name>
   <node f="40"><name></name></node></node>
  <node f="42"><name>connectionscenter</name>
   <node f="40"><name></name></node></node>
 </node>
 <node f="42"><name>events</name>
  <node f="40"><name></name></node></node>
 <node f="42" dt="7"><name>resetvalues</name><data/>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>sdt::attributetree</name><data>ObjectResetValues</data>
   <node f="40"><name></name></node></node>
 </node>
 <node f="42"><name>stored</name></node>
 <node f="42"><name>Groups</name>
  <node f="40"><name></name></node>
  <node f="810000042" dt="3"><name></name><data><coupling>/Tools/Groups/EntryTransfers/_2</coupling></data></node>
 </node>
</data>
 <node f="40"><name></name></node></node>
<node f="10000072" dt="4"><name>WaitingLine17</name><data>
 <node f="40"><name></name></node>
 <node f="42"><name>superclasses</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>FlexSimObject</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>classes</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>People::WaitingLine</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>variables</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>points</name><data>0000000000000000</data>
   <node f="40"><name></name></node>
   <node f="42" dt="7"><name></name><data/>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>x</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>y</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>z</name><data>0000000000000000</data></node>
    <node f="42" dt="2"><name>sdt::attributetree</name><data>People::WaitingLine::Point</data>
     <node f="40"><name></name></node></node>
   </node>
   <node f="42" dt="7"><name></name><data/>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>x</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>y</name><data>00000000c0100000</data></node>
    <node f="42" dt="1"><name>z</name><data>0000000000000000</data></node>
    <node f="42" dt="2"><name>sdt::attributetree</name><data>People::WaitingLine::Point</data>
     <node f="40"><name></name></node></node>
   </node>
  </node>
  <node f="42" dt="1"><name>travelers</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>incomingTravelers</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>gapSize</name><data>9999999a3fb99999</data></node>
  <node f="42" dt="1"><name>singleEntryPoint</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>width</name><data>9999999a3fe99999</data></node>
  <node f="42" dt="1"><name>height</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>floorRepeatX</name><data>9999999a3fe99999</data></node>
  <node f="42" dt="1"><name>floorRepeatY</name><data>9999999a3fe99999</data></node>
  <node f="42" dt="1"><name>stanchionRepeat</name><data>000000003ff00000</data></node>
  <node f="42" dt="2"><name>floorTexture</name><data>modules\People\bitmaps\waitingLine\floors\chevron.png</data></node>
  <node f="42" dt="2"><name>stanchionTexture</name><data>modules\People\bitmaps\waitingLine\stanchions\belt.png</data></node>
  <node f="42" dt="1"><name>drawFloor</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>drawStanchions</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>floorColor</name><data>0000000000000000</data>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>1eb851eb3fddeb85</data></node>
   <node f="42" dt="1"><name></name><data>e147ae153fe8147a</data></node>
   <node f="42" dt="1"><name></name><data>47ae147b3fea7ae1</data></node>
  </node>
  <node f="42" dt="1"><name>stanchionColor</name><data>0000000000000000</data>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
   <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
   <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
  </node>
  <node f="42" dt="1"><name>pointSize</name><data>00000000402e0000</data></node>
  <node f="42"><name>timetables</name></node>
  <node f="42"><name>networknodes</name></node>
  <node f="42" dt="1"><name>timeoflaststop</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>nrofstops</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>statebeforestop</name><data>0000000000000000</data></node>
  <node f="42"><name>collisionspheres</name></node>
  <node f="42"><name>collisionobjects</name></node>
  <node f="42" dt="1"><name>savedstate</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>resetposition</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>doanimations</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>floorTextureIndex</name><data>0000000040574000</data></node>
  <node f="42" dt="1"><name>stanchionTextureIndex</name><data>0000000040570000</data></node>
  <node f="200000042"><name>onPersonReady</name>
   <node f="40"><name></name></node></node>
  <node f="200000042"><name>onEntry</name>
   <node f="40"><name></name></node></node>
  <node f="200000042"><name>onExit</name>
   <node f="40"><name></name></node></node>
 </node>
 <node f="42"><name>behavior</name>
  <node f="40"><name></name></node>
  <node f="42"><name>eventfunctions</name>
   <node f="40"><name></name></node></node>
 </node>
 <node f="42"><name>special</name>
  <node f="40"><name></name></node>
  <node f="4000000042" dt="2"><name>title</name><data>Location</data></node>
  <node f="42" dt="2"><name>description</name><data></data></node>
  <node f="42" dt="2"><name>guifocusclass</name><data>VIEW:/standardviews/modelingutilities/QuickerProperties</data></node>
  <node f="42" dt="2"><name>tooltip</name><data>A location for persons to go to</data></node>
 </node>
 <node f="42"><name>visual</name>
  <node f="40"><name></name></node>
  <node f="42"><name>color</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name>red</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>green</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>blue</name><data>0000000000000000</data></node>
  </node>
  <node f="42" dt="2"><name>shape</name><data></data></node>
  <node f="42" dt="1"><name>shapeindex</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imageobject</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexobject</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imagebase</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexbase</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>drawflags</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>frame</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>picture</name><data>modules\People\bitmaps\waitingLine\waitinglinesmall.png</data></node>
 </node>
 <node f="42"><name>spatial</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>spatialx</name><data>00000000402a0000</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>00000000c03b0000</data></node>
  <node f="42" dt="1"><name>spatialz</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialsx</name><data>9999999a3fd99999</data></node>
  <node f="42" dt="1"><name>spatialsy</name><data>9999999a3fd99999</data></node>
  <node f="42" dt="1"><name>spatialsz</name><data>51eb851f3ff11eb8</data></node>
  <node f="42" dt="1"><name>spatialrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialrz</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetx</name><data>a0000000bf98f4db</data></node>
  <node f="42" dt="1"><name>offsety</name><data>c00000003fb034ac</data></node>
  <node f="42" dt="1"><name>offsetz</name><data>a00000003f44b636</data></node>
  <node f="42" dt="1"><name>offsetsx</name><data>000000003ff0c7a7</data></node>
  <node f="42" dt="1"><name>offsetsy</name><data>800000003ff0cf20</data></node>
  <node f="42" dt="1"><name>offsetsz</name><data>e00000003fed0888</data></node>
  <node f="42" dt="1"><name>offsetrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetrz</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>centroid</name><data>0000000040000000</data>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>000000003fe00000</data></node>
   <node f="42" dt="1"><name></name><data>000000003fe00000</data></node>
   <node f="42" dt="1"><name></name><data>000000003fe00000</data></node>
  </node>
 </node>
 <node f="42"><name>labels</name>
  <node f="40"><name></name></node></node>
 <node f="42"><name>objectinfo</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>Content:  0</name><data>0000000000000000</data></node>
 </node>
 <node f="42"><name>behaviour</name>
  <node f="40"><name></name></node></node>
 <node f="42"><name>stats</name>
  <node f="40"><name></name></node>
  <node f="42" dt="7"><name>state_current</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="6"><name>profile</name><data f="1">
    <fields>
     <field name="state" bytesize="36" type="259"/>
     <field name="time" bytesize="8" type="1"/>
     <field name="active" bytesize="4" type="2"/>
    </fields>
    <entry><ed>none</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>idle</ed><ed>0000000000000000</ed><ed>0</ed></entry></data></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040100000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_input</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040000000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_output</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040000000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_content</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulative</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulativeTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>minValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>maxValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>numEntries</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>lastSetTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>rate</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>lastResetTime</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_staytime</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040080000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="1"><name>stats_creationtime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>stats_lastmovetime</name><data>0000000000000000</data></node>
 </node>
 <node f="42"><name>connections</name>
  <node f="40"><name></name></node>
  <node f="42"><name>connectionsin</name>
   <node f="40"><name></name></node></node>
  <node f="42"><name>connectionsout</name>
   <node f="40"><name></name></node></node>
  <node f="42"><name>connectionscenter</name>
   <node f="40"><name></name></node></node>
 </node>
 <node f="42"><name>events</name>
  <node f="40"><name></name></node></node>
 <node f="42" dt="7"><name>resetvalues</name><data/>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>sdt::attributetree</name><data>ObjectResetValues</data>
   <node f="40"><name></name></node></node>
 </node>
 <node f="42"><name>stored</name></node>
 <node f="4000000042" dt="2"><name>windowtitle</name><data>FlexSimObject</data>
  <node f="40"><name></name></node></node>
 <node f="42"><name>templateobject</name>
  <node f="40"><name></name></node></node>
 <node f="80000042"><name>templateoverrides</name>
  <node f="40"><name></name></node>
  <node f="42"><name>Name</name></node>
  <node f="42"><name>Location</name></node>
  <node f="42"><name>ResetPosition</name></node>
  <node f="42"><name>Groups</name></node>
 </node>
 <node f="42"><name>Groups</name>
  <node f="40"><name></name></node>
  <node f="810000042" dt="3"><name></name><data><coupling>/Tools/Groups/Departure Queues/_1</coupling></data></node>
 </node>
</data>
 <node f="40"><name></name></node></node>
<node f="10000072" dt="4"><name>WaitingLine18</name><data>
 <node f="40"><name></name></node>
 <node f="42"><name>superclasses</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>FlexSimObject</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>classes</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>People::WaitingLine</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>variables</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>points</name><data>0000000000000000</data>
   <node f="40"><name></name></node>
   <node f="42" dt="7"><name></name><data/>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>x</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>y</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>z</name><data>0000000000000000</data></node>
    <node f="42" dt="2"><name>sdt::attributetree</name><data>People::WaitingLine::Point</data>
     <node f="40"><name></name></node></node>
   </node>
   <node f="42" dt="7"><name></name><data/>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>x</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>y</name><data>00000000c0100000</data></node>
    <node f="42" dt="1"><name>z</name><data>0000000000000000</data></node>
    <node f="42" dt="2"><name>sdt::attributetree</name><data>People::WaitingLine::Point</data>
     <node f="40"><name></name></node></node>
   </node>
  </node>
  <node f="42" dt="1"><name>travelers</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>incomingTravelers</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>gapSize</name><data>9999999a3fb99999</data></node>
  <node f="42" dt="1"><name>singleEntryPoint</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>width</name><data>9999999a3fe99999</data></node>
  <node f="42" dt="1"><name>height</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>floorRepeatX</name><data>9999999a3fe99999</data></node>
  <node f="42" dt="1"><name>floorRepeatY</name><data>9999999a3fe99999</data></node>
  <node f="42" dt="1"><name>stanchionRepeat</name><data>000000003ff00000</data></node>
  <node f="42" dt="2"><name>floorTexture</name><data>modules\People\bitmaps\waitingLine\floors\chevron.png</data></node>
  <node f="42" dt="2"><name>stanchionTexture</name><data>modules\People\bitmaps\waitingLine\stanchions\belt.png</data></node>
  <node f="42" dt="1"><name>drawFloor</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>drawStanchions</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>floorColor</name><data>0000000000000000</data>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>1eb851eb3fddeb85</data></node>
   <node f="42" dt="1"><name></name><data>e147ae153fe8147a</data></node>
   <node f="42" dt="1"><name></name><data>47ae147b3fea7ae1</data></node>
  </node>
  <node f="42" dt="1"><name>stanchionColor</name><data>0000000000000000</data>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
   <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
   <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
  </node>
  <node f="42" dt="1"><name>pointSize</name><data>00000000402e0000</data></node>
  <node f="42"><name>timetables</name></node>
  <node f="42"><name>networknodes</name></node>
  <node f="42" dt="1"><name>timeoflaststop</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>nrofstops</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>statebeforestop</name><data>0000000000000000</data></node>
  <node f="42"><name>collisionspheres</name></node>
  <node f="42"><name>collisionobjects</name></node>
  <node f="42" dt="1"><name>savedstate</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>resetposition</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>doanimations</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>floorTextureIndex</name><data>0000000040574000</data></node>
  <node f="42" dt="1"><name>stanchionTextureIndex</name><data>0000000040570000</data></node>
  <node f="200000042"><name>onPersonReady</name>
   <node f="40"><name></name></node></node>
  <node f="200000042"><name>onEntry</name>
   <node f="40"><name></name></node></node>
  <node f="200000042"><name>onExit</name>
   <node f="40"><name></name></node></node>
 </node>
 <node f="42"><name>behavior</name>
  <node f="40"><name></name></node>
  <node f="42"><name>eventfunctions</name>
   <node f="40"><name></name></node></node>
 </node>
 <node f="42"><name>special</name>
  <node f="40"><name></name></node>
  <node f="4000000042" dt="2"><name>title</name><data>Location</data></node>
  <node f="42" dt="2"><name>description</name><data></data></node>
  <node f="42" dt="2"><name>guifocusclass</name><data>VIEW:/standardviews/modelingutilities/QuickerProperties</data></node>
  <node f="42" dt="2"><name>tooltip</name><data>A location for persons to go to</data></node>
 </node>
 <node f="42"><name>visual</name>
  <node f="40"><name></name></node>
  <node f="42"><name>color</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name>red</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>green</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>blue</name><data>0000000000000000</data></node>
  </node>
  <node f="42" dt="2"><name>shape</name><data></data></node>
  <node f="42" dt="1"><name>shapeindex</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imageobject</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexobject</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imagebase</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexbase</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>drawflags</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>frame</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>picture</name><data>modules\People\bitmaps\waitingLine\waitinglinesmall.png</data></node>
 </node>
 <node f="42"><name>spatial</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>spatialx</name><data>00000000402e0000</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>00000000c03b0000</data></node>
  <node f="42" dt="1"><name>spatialz</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialsx</name><data>9999999a3fd99999</data></node>
  <node f="42" dt="1"><name>spatialsy</name><data>9999999a3fd99999</data></node>
  <node f="42" dt="1"><name>spatialsz</name><data>51eb851f3ff11eb8</data></node>
  <node f="42" dt="1"><name>spatialrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialrz</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetx</name><data>a0000000bf98f4db</data></node>
  <node f="42" dt="1"><name>offsety</name><data>c00000003fb034ac</data></node>
  <node f="42" dt="1"><name>offsetz</name><data>a00000003f44b636</data></node>
  <node f="42" dt="1"><name>offsetsx</name><data>000000003ff0c7a7</data></node>
  <node f="42" dt="1"><name>offsetsy</name><data>800000003ff0cf20</data></node>
  <node f="42" dt="1"><name>offsetsz</name><data>e00000003fed0888</data></node>
  <node f="42" dt="1"><name>offsetrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetrz</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>centroid</name><data>0000000040000000</data>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>000000003fe00000</data></node>
   <node f="42" dt="1"><name></name><data>000000003fe00000</data></node>
   <node f="42" dt="1"><name></name><data>000000003fe00000</data></node>
  </node>
 </node>
 <node f="42"><name>labels</name>
  <node f="40"><name></name></node></node>
 <node f="42"><name>objectinfo</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>Content:  0</name><data>0000000000000000</data></node>
 </node>
 <node f="42"><name>behaviour</name>
  <node f="40"><name></name></node></node>
 <node f="42"><name>stats</name>
  <node f="40"><name></name></node>
  <node f="42" dt="7"><name>state_current</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="6"><name>profile</name><data f="1">
    <fields>
     <field name="state" bytesize="36" type="259"/>
     <field name="time" bytesize="8" type="1"/>
     <field name="active" bytesize="4" type="2"/>
    </fields>
    <entry><ed>none</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>idle</ed><ed>0000000000000000</ed><ed>0</ed></entry></data></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040100000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_input</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040000000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_output</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040000000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_content</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulative</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulativeTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>minValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>maxValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>numEntries</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>lastSetTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>rate</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>lastResetTime</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="7"><name>stats_staytime</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040080000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="1"><name>stats_creationtime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>stats_lastmovetime</name><data>0000000000000000</data></node>
 </node>
 <node f="42"><name>connections</name>
  <node f="40"><name></name></node>
  <node f="42"><name>connectionsin</name>
   <node f="40"><name></name></node></node>
  <node f="42"><name>connectionsout</name>
   <node f="40"><name></name></node></node>
  <node f="42"><name>connectionscenter</name>
   <node f="40"><name></name></node></node>
 </node>
 <node f="42"><name>events</name>
  <node f="40"><name></name></node></node>
 <node f="42" dt="7"><name>resetvalues</name><data/>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>sdt::attributetree</name><data>ObjectResetValues</data>
   <node f="40"><name></name></node></node>
 </node>
 <node f="42"><name>stored</name></node>
 <node f="4000000042" dt="2"><name>windowtitle</name><data>FlexSimObject</data>
  <node f="40"><name></name></node></node>
 <node f="42"><name>templateobject</name>
  <node f="40"><name></name></node></node>
 <node f="80000042"><name>templateoverrides</name>
  <node f="40"><name></name></node>
  <node f="42"><name>Name</name></node>
  <node f="42"><name>Location</name></node>
  <node f="42"><name>ResetPosition</name></node>
  <node f="42"><name>Groups</name></node>
 </node>
 <node f="42"><name>Groups</name>
  <node f="40"><name></name></node>
  <node f="810000042" dt="3"><name></name><data><coupling>/Tools/Groups/Departure Queues/_2</coupling></data></node>
 </node>
</data>
 <node f="40"><name></name></node></node></flexsim-tree>
