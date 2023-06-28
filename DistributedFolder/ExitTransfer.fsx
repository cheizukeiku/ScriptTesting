<?xml version="1.0" encoding="UTF-8"?>
<flexsim-tree version="4" treetype="distributed">
<node f="62" dt="4"><name>ExitTransfer3</name><data>
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
   <node f="10000042" dt="3"><name></name><data><coupling>/CurvedConveyor1&gt;variables/conveyorPoints/_2</coupling></data></node>
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
  <node f="42" dt="1"><name>spatialx</name><data>2666666640417027</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>314bd946c03d69b4</data></node>
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
 </node>
 <node f="42"><name>labels</name>
  <node f="40"><name></name></node></node>
 <node f="42"><name>connections</name>
  <node f="40"><name></name></node>
  <node f="42"><name>connectionsin</name>
   <node f="40"><name></name></node></node>
  <node f="42"><name>connectionsout</name>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name></name><data><coupling>/Luggage Out 2&gt;connections/connectionsin/1</coupling></data>
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
  <node f="810000042" dt="3"><name></name><data><coupling>/Tools/Groups/ExitTransfers/_2</coupling></data></node>
 </node>
</data></node></flexsim-tree>
