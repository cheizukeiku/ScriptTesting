<?xml version="1.0" encoding="UTF-8"?>
<flexsim-tree version="4" treetype="distributed">
<node f="62" dt="4"><name>EntryTransfer1</name><data>
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
   <node f="10000042" dt="3"><name></name><data><coupling>/StraightConveyor1&gt;variables/conveyorPoints/_1</coupling></data></node>
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
  <node f="42" dt="1"><name>spatialx</name><data>3036fecd4036b20f</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>66666666c0396666</data></node>
  <node f="42" dt="1"><name>spatialz</name><data>00000000bfe00000</data></node>
  <node f="42" dt="1"><name>spatialsx</name><data>9999999a3fc99999</data></node>
  <node f="42" dt="1"><name>spatialsy</name><data>9999999a3fc99999</data></node>
  <node f="42" dt="1"><name>spatialsz</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>spatialrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialrz</name><data>0000000000000000</data></node>
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
   <node f="10000042" dt="3"><name></name><data><coupling>/Bag Drop 3&gt;connections/connectionsout/1</coupling></data>
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
  <node f="810000042" dt="3"><name></name><data><coupling>/Tools/Groups/EntryTransfers/_1</coupling></data></node>
 </node>
</data>
 <node f="40"><name></name></node></node>
<node f="62" dt="4"><name>StraightConveyor2</name><data>
 <node f="40"><name></name></node>
 <node f="42"><name>superclasses</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Conveyor::Conveyor</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>classes</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Conveyor::StraightConveyor</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>variables</name>
  <node f="40"><name></name></node>
  <node f="42"><name>mergeController</name></node>
  <node f="42"><name>traversals</name></node>
  <node f="42" dt="1"><name>accumType</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>acceleration</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>deceleration</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>stopSpaceSizeFactor</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>stopSpacePadding</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>moveSpaceSizeFactor</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>moveSpacePadding</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>entrySpaceSizeFactor</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>entrySpacePadding</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>restartDelay</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>useFixedIntervalMovement</name><data>0000000000000000</data></node>
  <node f="42"><name>fixedIntervalPattern</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
  </node>
  <node f="42" dt="1"><name>fixedIntervalItemEdge</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>useCatchCondition</name><data>0000000000000000</data></node>
  <node f="442" dt="2"><name>catchCondition</name><data>Conveyor current = ownerobject(c);
Object item = param(1);
int dogNum = param(2);
int groupNum = param(3);
int groupMemberNum = param(4);

/**Always Catch*/
return 1;
</data></node>
  <node f="42" dt="1"><name>isSlugBuilder</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>isSlugReadyByFillPercent</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>slugFillPercent</name><data>0000000040540000</data></node>
  <node f="42" dt="1"><name>isSlugReadyByTime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugReadyTime</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>isSlugReadyByItemCount</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugItemCount</name><data>0000000040240000</data></node>
  <node f="42" dt="1"><name>slugReleaseSpeed</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>hasSlugMaxItemCount</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugMaxItemCount</name><data>0000000040240000</data></node>
  <node f="42" dt="1"><name>length</name><data>47ae147b40107ae1</data></node>
  <node f="42" dt="1"><name>rise</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>useVirtualLength</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>virtualLength</name><data>0000000040240000</data></node>
  <node f="42"><name>system</name>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name></name><data><coupling>/ConveyorSystem&gt;variables/conveyors/_2</coupling></data></node>
  </node>
  <node f="42"><name>motor</name></node>
  <node f="42" dt="3"><name>visualization</name><data><coupling>/ConveyorSystem&gt;variables/visualizations/BeltConveyor</coupling></data></node>
  <node f="42" dt="1"><name>width</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>rollerAngle</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>speed</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>conveyorPoints</name><data>0000000000000000</data>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name>_1</name><data><coupling>/EntryTransfer3&gt;variables/transferPoint/1</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>distAlong</name><data>0000000000000000</data></node>
    <node f="10000042" dt="3"><name>system</name><data><coupling>/ConveyorSystem&gt;variables/conveyorPoints/_3</coupling></data></node>
    <node f="42" dt="1"><name>distOffCenter</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>rangeWidth</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>isAtSide</name><data>0000000000000000</data></node>
    <node f="42" dt="2"><name>sdt::attributetree</name><data>Conveyor::FRTransferPoint</data>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>flowRateRatio</name><data>0000000000000000</data></node>
    </node>
   </node>
   <node f="10000042" dt="3"><name>_2</name><data><coupling>/StraightConveyor4&gt;variables/conveyorPoints/_1</coupling></data>
    <node f="40"><name></name></node>
    <node f="42"><name>allocations</name></node>
    <node f="42"><name>allocationRequests</name></node>
    <node f="42" dt="1"><name>distAlong</name><data>47ae147b40107ae1</data></node>
    <node f="10000042" dt="3"><name>system</name><data><coupling>/ConveyorSystem&gt;variables/conveyorPoints/_7</coupling></data></node>
    <node f="42" dt="1"><name>distOffCenter</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>transferAngle</name><data>0000000040568000</data></node>
    <node f="42" dt="3"><name>type</name><data><coupling>/ConveyorSystem&gt;variables/transferTypes/TransferType1</coupling></data></node>
    <node f="42"><name>massFlowTransfer</name></node>
    <node f="42" dt="2"><name>sdt::attributetree</name><data>Conveyor::ConveyorTransfer</data>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>flowRateRatio</name><data>0000000000000000</data></node>
     <node f="42" dt="3"><name>exitWaitingTraversal</name><data><coupling>null</coupling></data></node>
     <node f="42" dt="3"><name>newWaitingTraversal</name><data><coupling>null</coupling></data></node>
     <node f="42" dt="1"><name>isAtSide</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>driverCurAcc</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>driverCurAccTime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>driverStartTime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>driverStartSpeed</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>driverTargetSpeed</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>driverStartDist</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>driverHaltTime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>needsKinematicOffsetAtCenterTraversal</name><data>0000000000000000</data></node>
    </node>
   </node>
  </node>
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
 <node f="42"><name>spatial</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>spatialx</name><data>2978efca3fff7b03</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>c82bbd1ac024ff56</data></node>
  <node f="42" dt="1"><name>spatialz</name><data>000000003fe00000</data></node>
  <node f="42" dt="1"><name>spatialsx</name><data>47ae147b40107ae1</data></node>
  <node f="42" dt="1"><name>spatialsy</name><data>000000003fe00000</data></node>
  <node f="42" dt="1"><name>spatialsz</name><data>a00000003fc99999</data></node>
  <node f="42" dt="1"><name>spatialrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialrz</name><data>00000000c0668000</data></node>
  <node f="42" dt="1"><name>centroid</name><data>0000000000000000</data></node>
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
    <entry><ed>none</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>idle</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>processing</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>busy</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>blocked</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>generating</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>empty</ed><ed>0000000000000000</ed><ed>1</ed></entry>
    <entry><ed>collecting</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>releasing</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>waiting for operator</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>waiting for transporter</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>breakdown</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>scheduled down</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>conveying</ed><ed>0000000000000000</ed><ed>1</ed></entry></data></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040100000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000040400000</data></node>
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
  <node f="42" dt="1"><name>simLength</name><data>47ae147b40107ae1</data></node>
  <node f="42" dt="1"><name>isDirectionReversed</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>curTargetSpeed</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>driverCurAcc</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>driverCurAccTime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>driverStartTime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>driverStartSpeed</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>driverTargetSpeed</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>driverStartDist</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>driverHaltTime</name><data>00000000bff00000</data></node>
  <node f="42" dt="1"><name>numStoppedNonAccumItems</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugBuildState</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugBuildFillLength</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugBuildItemCount</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugBuildMaxItemCount</name><data>ffc0000041dfffff</data></node>
  <node f="42" dt="3"><name>lastSlugItem</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="3"><name>slugReadyEvent</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="3"><name>nonAccumSlugEnteringItem</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="1"><name>hasNonAccumSlugBlockedItem</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>fixedIntervalDriverOffset</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>traversalPoints</name><data>0000000000000000</data></node>
  <node f="42" dt="3"><name>fixedIntervalEvent</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="1"><name>nonAccumStoppedBlockerClearPoints</name><data>0000000000000000</data></node>
  <node f="42" dt="3"><name>nonAccumFullStopEvent</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="1"><name>beltRepeatDist</name><data>0000000040140000</data></node>
 </node>
 <node f="42"><name>special</name>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>windowtitle</name><data>StraightConveyor</data></node>
  <node f="42" dt="2"><name>title</name><data>Conveyor</data></node>
  <node f="42" dt="2"><name>description</name><data></data></node>
  <node f="42" dt="2"><name>guifocusclass</name><data>VIEW:/standardviews/modelingutilities/QuickerProperties</data></node>
 </node>
 <node f="42"><name>visual</name>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>picture</name><data>modules\Conveyor\bitmaps\ConveyorSection.png</data></node>
  <node f="42"><name>color</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name>red</name><data>51eb851f3fed1eb8</data></node>
   <node f="42" dt="1"><name>green</name><data>51eb851f3fed1eb8</data></node>
   <node f="42" dt="1"><name>blue</name><data>51eb851f3fed1eb8</data></node>
  </node>
  <node f="42" dt="2"><name>shape</name><data>***</data></node>
  <node f="42" dt="1"><name>shapeindex</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imagebase</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexbase</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imageobject</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexobject</name><data>0000000000000000</data></node>
  <node f="42"><name>objectinfo</name>
   <node f="40"><name></name></node>
   <node f="42"><name></name></node>
   <node f="42"><name></name></node>
   <node f="42"><name></name></node>
  </node>
 </node>
 <node f="4000000042" dt="2"><name>windowtitle</name><data>StraightConveyor</data>
  <node f="40"><name></name></node></node>
 <node f="42"><name>labels</name>
  <node f="40"><name></name></node></node>
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
 <node f="42"><name>Groups</name>
  <node f="40"><name></name></node>
  <node f="810000042" dt="3"><name></name><data><coupling>/Tools/Groups/Conveyors/_2</coupling></data>
   <node f="40"><name></name></node></node>
 </node>
</data>
 <node f="40"><name></name></node></node>
<node f="20042" dt="4"><name>Bag Drop 1</name><data>
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
  <node f="42" dt="1"><name>spatialx</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>00000000c0240000</data></node>
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
   <node f="10000042" dt="3"><name></name><data><coupling>/EntryTransfer3&gt;connections/connectionsin/1</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
    <node f="42" dt="3"><name></name><data><coupling>null</coupling></data></node>
   </node>
  </node>
  <node f="42"><name>connectionscenter</name>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name></name><data><coupling>/WaitingLine1&gt;connections/connectionscenter/1</coupling></data>
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
 <node f="42"><name>Groups</name>
  <node f="40"><name></name></node></node>
</data></node>
<node f="20042" dt="4"><name>Bag Drop 2</name><data>
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
  <node f="42" dt="1"><name>spatialx</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>00000000c02a0000</data></node>
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
   <node f="10000042" dt="3"><name></name><data><coupling>/EntryTransfer4&gt;connections/connectionsin/1</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
    <node f="42" dt="3"><name></name><data><coupling>null</coupling></data></node>
   </node>
  </node>
  <node f="42"><name>connectionscenter</name>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name></name><data><coupling>/WaitingLine2&gt;connections/connectionscenter/1</coupling></data>
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
 <node f="42"><name>Groups</name>
  <node f="40"><name></name></node></node>
</data></node>
<node f="62" dt="4"><name>StraightConveyor3</name><data>
 <node f="40"><name></name></node>
 <node f="42"><name>superclasses</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Conveyor::Conveyor</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>classes</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Conveyor::StraightConveyor</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>variables</name>
  <node f="40"><name></name></node>
  <node f="42"><name>mergeController</name></node>
  <node f="42"><name>traversals</name></node>
  <node f="42" dt="1"><name>accumType</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>acceleration</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>deceleration</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>stopSpaceSizeFactor</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>stopSpacePadding</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>moveSpaceSizeFactor</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>moveSpacePadding</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>entrySpaceSizeFactor</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>entrySpacePadding</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>restartDelay</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>useFixedIntervalMovement</name><data>0000000000000000</data></node>
  <node f="42"><name>fixedIntervalPattern</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
  </node>
  <node f="42" dt="1"><name>fixedIntervalItemEdge</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>useCatchCondition</name><data>0000000000000000</data></node>
  <node f="442" dt="2"><name>catchCondition</name><data>Conveyor current = ownerobject(c);
Object item = param(1);
int dogNum = param(2);
int groupNum = param(3);
int groupMemberNum = param(4);

/**Always Catch*/
return 1;
</data></node>
  <node f="42" dt="1"><name>isSlugBuilder</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>isSlugReadyByFillPercent</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>slugFillPercent</name><data>0000000040540000</data></node>
  <node f="42" dt="1"><name>isSlugReadyByTime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugReadyTime</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>isSlugReadyByItemCount</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugItemCount</name><data>0000000040240000</data></node>
  <node f="42" dt="1"><name>slugReleaseSpeed</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>hasSlugMaxItemCount</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugMaxItemCount</name><data>0000000040240000</data></node>
  <node f="42" dt="1"><name>length</name><data>fb79498940107682</data></node>
  <node f="42" dt="1"><name>rise</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>useVirtualLength</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>virtualLength</name><data>0000000040240000</data></node>
  <node f="42"><name>system</name>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name></name><data><coupling>/ConveyorSystem&gt;variables/conveyors/_3</coupling></data></node>
  </node>
  <node f="42"><name>motor</name></node>
  <node f="42" dt="3"><name>visualization</name><data><coupling>/ConveyorSystem&gt;variables/visualizations/BeltConveyor</coupling></data></node>
  <node f="42" dt="1"><name>width</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>rollerAngle</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>speed</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>conveyorPoints</name><data>0000000000000000</data>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name>_1</name><data><coupling>/EntryTransfer4&gt;variables/transferPoint/1</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>distAlong</name><data>0000000000000000</data></node>
    <node f="10000042" dt="3"><name>system</name><data><coupling>/ConveyorSystem&gt;variables/conveyorPoints/_4</coupling></data></node>
    <node f="42" dt="1"><name>distOffCenter</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>rangeWidth</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>isAtSide</name><data>0000000000000000</data></node>
    <node f="42" dt="2"><name>sdt::attributetree</name><data>Conveyor::FRTransferPoint</data>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>flowRateRatio</name><data>0000000000000000</data></node>
    </node>
   </node>
   <node f="10000042" dt="3"><name>_2</name><data><coupling>/StraightConveyor4&gt;variables/conveyorPoints/_2</coupling></data>
    <node f="40"><name></name></node>
    <node f="42"><name>allocations</name></node>
    <node f="42"><name>allocationRequests</name></node>
    <node f="42" dt="1"><name>distAlong</name><data>fb79498940107682</data></node>
    <node f="10000042" dt="3"><name>system</name><data><coupling>/ConveyorSystem&gt;variables/conveyorPoints/_9</coupling></data></node>
    <node f="42" dt="1"><name>distOffCenter</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>transferAngle</name><data>0000000040568000</data></node>
    <node f="42" dt="3"><name>type</name><data><coupling>/ConveyorSystem&gt;variables/transferTypes/TransferType1</coupling></data></node>
    <node f="42"><name>massFlowTransfer</name></node>
    <node f="42" dt="2"><name>sdt::attributetree</name><data>Conveyor::ConveyorTransfer</data>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>flowRateRatio</name><data>0000000000000000</data></node>
     <node f="42" dt="3"><name>exitWaitingTraversal</name><data><coupling>null</coupling></data></node>
     <node f="42" dt="3"><name>newWaitingTraversal</name><data><coupling>null</coupling></data></node>
     <node f="42" dt="1"><name>isAtSide</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>driverCurAcc</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>driverCurAccTime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>driverStartTime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>driverStartSpeed</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>driverTargetSpeed</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>driverStartDist</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>driverHaltTime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>needsKinematicOffsetAtCenterTraversal</name><data>0000000000000000</data></node>
    </node>
   </node>
  </node>
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
 <node f="42"><name>spatial</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>spatialx</name><data>fbe1a6583fffc930</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>f2e14c73c02b1705</data></node>
  <node f="42" dt="1"><name>spatialz</name><data>000000003fe00000</data></node>
  <node f="42" dt="1"><name>spatialsx</name><data>fb79498940107682</data></node>
  <node f="42" dt="1"><name>spatialsy</name><data>000000003fe00000</data></node>
  <node f="42" dt="1"><name>spatialsz</name><data>a00000003fc99999</data></node>
  <node f="42" dt="1"><name>spatialrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialrz</name><data>0000000040668000</data></node>
  <node f="42" dt="1"><name>centroid</name><data>0000000000000000</data></node>
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
    <entry><ed>none</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>idle</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>processing</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>busy</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>blocked</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>generating</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>empty</ed><ed>0000000000000000</ed><ed>1</ed></entry>
    <entry><ed>collecting</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>releasing</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>waiting for operator</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>waiting for transporter</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>breakdown</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>scheduled down</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>conveying</ed><ed>0000000000000000</ed><ed>1</ed></entry></data></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040100000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000040400000</data></node>
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
  <node f="42" dt="1"><name>simLength</name><data>fb79498940107682</data></node>
  <node f="42" dt="1"><name>isDirectionReversed</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>curTargetSpeed</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>driverCurAcc</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>driverCurAccTime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>driverStartTime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>driverStartSpeed</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>driverTargetSpeed</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>driverStartDist</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>driverHaltTime</name><data>00000000bff00000</data></node>
  <node f="42" dt="1"><name>numStoppedNonAccumItems</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugBuildState</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugBuildFillLength</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugBuildItemCount</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugBuildMaxItemCount</name><data>ffc0000041dfffff</data></node>
  <node f="42" dt="3"><name>lastSlugItem</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="3"><name>slugReadyEvent</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="3"><name>nonAccumSlugEnteringItem</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="1"><name>hasNonAccumSlugBlockedItem</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>fixedIntervalDriverOffset</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>traversalPoints</name><data>0000000000000000</data></node>
  <node f="42" dt="3"><name>fixedIntervalEvent</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="1"><name>nonAccumStoppedBlockerClearPoints</name><data>0000000000000000</data></node>
  <node f="42" dt="3"><name>nonAccumFullStopEvent</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="1"><name>beltRepeatDist</name><data>0000000040140000</data></node>
 </node>
 <node f="42"><name>special</name>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>windowtitle</name><data>StraightConveyor</data></node>
  <node f="42" dt="2"><name>title</name><data>Conveyor</data></node>
  <node f="42" dt="2"><name>description</name><data></data></node>
  <node f="42" dt="2"><name>guifocusclass</name><data>VIEW:/standardviews/modelingutilities/QuickerProperties</data></node>
 </node>
 <node f="42"><name>visual</name>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>picture</name><data>modules\Conveyor\bitmaps\ConveyorSection.png</data></node>
  <node f="42"><name>color</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name>red</name><data>51eb851f3fed1eb8</data></node>
   <node f="42" dt="1"><name>green</name><data>51eb851f3fed1eb8</data></node>
   <node f="42" dt="1"><name>blue</name><data>51eb851f3fed1eb8</data></node>
  </node>
  <node f="42" dt="2"><name>shape</name><data>***</data></node>
  <node f="42" dt="1"><name>shapeindex</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imagebase</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexbase</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imageobject</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexobject</name><data>0000000000000000</data></node>
  <node f="42"><name>objectinfo</name>
   <node f="40"><name></name></node>
   <node f="42"><name></name></node>
   <node f="42"><name></name></node>
   <node f="42"><name></name></node>
  </node>
 </node>
 <node f="4000000042" dt="2"><name>windowtitle</name><data>StraightConveyor</data>
  <node f="40"><name></name></node></node>
 <node f="42"><name>labels</name>
  <node f="40"><name></name></node></node>
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
 <node f="42"><name>Groups</name>
  <node f="40"><name></name></node>
  <node f="810000042" dt="3"><name></name><data><coupling>/Tools/Groups/Conveyors/_3</coupling></data>
   <node f="40"><name></name></node></node>
 </node>
</data>
 <node f="40"><name></name></node></node>
<node f="62" dt="4"><name>StraightConveyor4</name><data>
 <node f="40"><name></name></node>
 <node f="42"><name>superclasses</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Conveyor::Conveyor</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>classes</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Conveyor::StraightConveyor</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>variables</name>
  <node f="40"><name></name></node>
  <node f="42"><name>mergeController</name></node>
  <node f="42"><name>traversals</name></node>
  <node f="42" dt="1"><name>accumType</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>acceleration</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>deceleration</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>stopSpaceSizeFactor</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>stopSpacePadding</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>moveSpaceSizeFactor</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>moveSpacePadding</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>entrySpaceSizeFactor</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>entrySpacePadding</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>restartDelay</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>useFixedIntervalMovement</name><data>0000000000000000</data></node>
  <node f="42"><name>fixedIntervalPattern</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
  </node>
  <node f="42" dt="1"><name>fixedIntervalItemEdge</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>useCatchCondition</name><data>0000000000000000</data></node>
  <node f="442" dt="2"><name>catchCondition</name><data>Conveyor current = ownerobject(c);
Object item = param(1);
int dogNum = param(2);
int groupNum = param(3);
int groupMemberNum = param(4);

/**Always Catch*/
return 1;
</data></node>
  <node f="42" dt="1"><name>isSlugBuilder</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>isSlugReadyByFillPercent</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>slugFillPercent</name><data>0000000040540000</data></node>
  <node f="42" dt="1"><name>isSlugReadyByTime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugReadyTime</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>isSlugReadyByItemCount</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugItemCount</name><data>0000000040240000</data></node>
  <node f="42" dt="1"><name>slugReleaseSpeed</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>hasSlugMaxItemCount</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugMaxItemCount</name><data>0000000040240000</data></node>
  <node f="42" dt="1"><name>length</name><data>ce1c463a4031db47</data></node>
  <node f="42" dt="1"><name>rise</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>useVirtualLength</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>virtualLength</name><data>0000000040240000</data></node>
  <node f="42"><name>system</name>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name></name><data><coupling>/ConveyorSystem&gt;variables/conveyors/_4</coupling></data></node>
  </node>
  <node f="42"><name>motor</name></node>
  <node f="42" dt="3"><name>visualization</name><data><coupling>/ConveyorSystem&gt;variables/visualizations/BeltConveyor</coupling></data></node>
  <node f="42" dt="1"><name>width</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>rollerAngle</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>speed</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>conveyorPoints</name><data>0000000000000000</data>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name>_1</name><data><coupling>/StraightConveyor2&gt;variables/conveyorPoints/_2</coupling></data>
    <node f="40"><name></name></node>
    <node f="42"><name>allocations</name></node>
    <node f="42"><name>allocationRequests</name></node>
    <node f="42" dt="1"><name>distAlong</name><data>7ec094253fe13b26</data></node>
    <node f="10000042" dt="3"><name>system</name><data><coupling>/ConveyorSystem&gt;variables/conveyorPoints/_8</coupling></data></node>
    <node f="42" dt="1"><name>distOffCenter</name><data>61cf4b803fd59bf9</data></node>
    <node f="42" dt="1"><name>transferAngle</name><data>00000000c0568000</data></node>
    <node f="42" dt="3"><name>type</name><data><coupling>/ConveyorSystem&gt;variables/transferTypes/TransferType1</coupling></data></node>
    <node f="42"><name>massFlowTransfer</name></node>
    <node f="42" dt="7"><name>localType</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>inlineSpeedType</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>sideSpeedType</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>inlineTransferMaxAngle</name><data>0000000040468000</data></node>
     <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>finishTime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>transferTime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>customSpeed</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>popupDist</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>doSmoothTransitions</name><data>000000003ff00000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>Conveyor::TransferType</data>
      <node f="40"><name></name></node></node>
    </node>
    <node f="42" dt="2"><name>sdt::attributetree</name><data>Conveyor::ConveyorTransfer</data>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>flowRateRatio</name><data>0000000000000000</data></node>
     <node f="42" dt="3"><name>exitWaitingTraversal</name><data><coupling>null</coupling></data></node>
     <node f="42" dt="3"><name>newWaitingTraversal</name><data><coupling>null</coupling></data></node>
     <node f="42" dt="1"><name>isAtSide</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>driverCurAcc</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>driverCurAccTime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>driverStartTime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>driverStartSpeed</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>driverTargetSpeed</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>driverStartDist</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>driverHaltTime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>needsKinematicOffsetAtCenterTraversal</name><data>0000000000000000</data></node>
    </node>
   </node>
   <node f="10000042" dt="3"><name>_2</name><data><coupling>/StraightConveyor3&gt;variables/conveyorPoints/_2</coupling></data>
    <node f="40"><name></name></node>
    <node f="42"><name>allocations</name></node>
    <node f="42"><name>allocationRequests</name></node>
    <node f="42" dt="1"><name>distAlong</name><data>9fb02509400cad86</data></node>
    <node f="10000042" dt="3"><name>system</name><data><coupling>/ConveyorSystem&gt;variables/conveyorPoints/_10</coupling></data></node>
    <node f="42" dt="1"><name>distOffCenter</name><data>6ebed4803fd71a95</data></node>
    <node f="42" dt="1"><name>transferAngle</name><data>00000000c0568000</data></node>
    <node f="42" dt="3"><name>type</name><data><coupling>/ConveyorSystem&gt;variables/transferTypes/TransferType1</coupling></data></node>
    <node f="42"><name>massFlowTransfer</name></node>
    <node f="42" dt="7"><name>localType</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>inlineSpeedType</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>sideSpeedType</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>inlineTransferMaxAngle</name><data>0000000040468000</data></node>
     <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>finishTime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>transferTime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>customSpeed</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>popupDist</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>doSmoothTransitions</name><data>000000003ff00000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>Conveyor::TransferType</data>
      <node f="40"><name></name></node></node>
    </node>
    <node f="42" dt="2"><name>sdt::attributetree</name><data>Conveyor::ConveyorTransfer</data>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>flowRateRatio</name><data>0000000000000000</data></node>
     <node f="42" dt="3"><name>exitWaitingTraversal</name><data><coupling>null</coupling></data></node>
     <node f="42" dt="3"><name>newWaitingTraversal</name><data><coupling>null</coupling></data></node>
     <node f="42" dt="1"><name>isAtSide</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>driverCurAcc</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>driverCurAccTime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>driverStartTime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>driverStartSpeed</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>driverTargetSpeed</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>driverStartDist</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>driverHaltTime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>needsKinematicOffsetAtCenterTraversal</name><data>0000000000000000</data></node>
    </node>
   </node>
   <node f="10000042" dt="3"><name>_3</name><data><coupling>/ExitTransfer2&gt;variables/transferPoint/1</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>distAlong</name><data>ce1c463a4031db47</data></node>
    <node f="10000042" dt="3"><name>system</name><data><coupling>/ConveyorSystem&gt;variables/conveyorPoints/_2</coupling></data></node>
    <node f="42" dt="1"><name>distOffCenter</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>rangeWidth</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>isAtSide</name><data>0000000000000000</data></node>
    <node f="42" dt="2"><name>sdt::attributetree</name><data>Conveyor::FRTransferPoint</data>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>flowRateRatio</name><data>0000000000000000</data></node>
    </node>
   </node>
  </node>
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
 <node f="42"><name>spatial</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>spatialx</name><data>26d99a83c003ebc0</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>5813f6bec023eba4</data></node>
  <node f="42" dt="1"><name>spatialz</name><data>000000003fe00000</data></node>
  <node f="42" dt="1"><name>spatialsx</name><data>ce1c463a4031db47</data></node>
  <node f="42" dt="1"><name>spatialsy</name><data>000000003fe00000</data></node>
  <node f="42" dt="1"><name>spatialsz</name><data>a00000003fc99999</data></node>
  <node f="42" dt="1"><name>spatialrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialrz</name><data>00000000c0568000</data></node>
  <node f="42" dt="1"><name>centroid</name><data>0000000000000000</data></node>
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
    <entry><ed>none</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>idle</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>processing</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>busy</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>blocked</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>generating</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>empty</ed><ed>0000000000000000</ed><ed>1</ed></entry>
    <entry><ed>collecting</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>releasing</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>waiting for operator</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>waiting for transporter</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>breakdown</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>scheduled down</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>conveying</ed><ed>0000000000000000</ed><ed>1</ed></entry></data></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040100000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000040400000</data></node>
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
  <node f="42" dt="1"><name>simLength</name><data>ce1c463a4031db47</data></node>
  <node f="42" dt="1"><name>isDirectionReversed</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>curTargetSpeed</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>driverCurAcc</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>driverCurAccTime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>driverStartTime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>driverStartSpeed</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>driverTargetSpeed</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>driverStartDist</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>driverHaltTime</name><data>00000000bff00000</data></node>
  <node f="42" dt="1"><name>numStoppedNonAccumItems</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugBuildState</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugBuildFillLength</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugBuildItemCount</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>slugBuildMaxItemCount</name><data>ffc0000041dfffff</data></node>
  <node f="42" dt="3"><name>lastSlugItem</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="3"><name>slugReadyEvent</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="3"><name>nonAccumSlugEnteringItem</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="1"><name>hasNonAccumSlugBlockedItem</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>fixedIntervalDriverOffset</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>traversalPoints</name><data>0000000000000000</data></node>
  <node f="42" dt="3"><name>fixedIntervalEvent</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="1"><name>nonAccumStoppedBlockerClearPoints</name><data>0000000000000000</data></node>
  <node f="42" dt="3"><name>nonAccumFullStopEvent</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="1"><name>beltRepeatDist</name><data>0000000040140000</data></node>
 </node>
 <node f="42"><name>special</name>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>windowtitle</name><data>StraightConveyor</data></node>
  <node f="42" dt="2"><name>title</name><data>Conveyor</data></node>
  <node f="42" dt="2"><name>description</name><data></data></node>
  <node f="42" dt="2"><name>guifocusclass</name><data>VIEW:/standardviews/modelingutilities/QuickerProperties</data></node>
 </node>
 <node f="42"><name>visual</name>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>picture</name><data>modules\Conveyor\bitmaps\ConveyorSection.png</data></node>
  <node f="42"><name>color</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name>red</name><data>51eb851f3fed1eb8</data></node>
   <node f="42" dt="1"><name>green</name><data>51eb851f3fed1eb8</data></node>
   <node f="42" dt="1"><name>blue</name><data>51eb851f3fed1eb8</data></node>
  </node>
  <node f="42" dt="2"><name>shape</name><data>***</data></node>
  <node f="42" dt="1"><name>shapeindex</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imagebase</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexbase</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imageobject</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexobject</name><data>0000000000000000</data></node>
  <node f="42"><name>objectinfo</name>
   <node f="40"><name></name></node>
   <node f="42"><name></name></node>
   <node f="42"><name></name></node>
   <node f="42"><name></name></node>
  </node>
 </node>
 <node f="4000000042" dt="2"><name>windowtitle</name><data>StraightConveyor</data>
  <node f="40"><name></name></node></node>
 <node f="42"><name>labels</name>
  <node f="40"><name></name></node></node>
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
 <node f="42"><name>Groups</name>
  <node f="40"><name></name></node>
  <node f="810000042" dt="3"><name></name><data><coupling>/Tools/Groups/Conveyors/_4</coupling></data></node>
 </node>
</data>
 <node f="40"><name></name></node></node>
<node f="42" dt="4"><name>Luggage Out 1</name><data>
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
  <node f="42" dt="1"><name>usebatching</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>batchsize</name><data>0000000040320000</data></node>
  <node f="42" dt="1"><name>maxwaittime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>flush</name><data>000000003ff00000</data></node>
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
  <node f="42" dt="1"><name>spatialx</name><data>00000000c0100000</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>00000000c03c0000</data></node>
  <node f="42" dt="1"><name>spatialz</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialsx</name><data>0000000040000000</data></node>
  <node f="42" dt="1"><name>spatialsy</name><data>0000000040000000</data></node>
  <node f="42" dt="1"><name>spatialsz</name><data>9999999a3fc99999</data></node>
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
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name></name><data><coupling>/ExitTransfer2&gt;connections/connectionsout/1</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
    <node f="42" dt="3"><name></name><data><coupling>null</coupling></data></node>
   </node>
  </node>
  <node f="42"><name>connectionsout</name>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name></name><data><coupling>/Luggage Out Sink&gt;connections/connectionsin/_1</coupling></data>
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
</data></node></flexsim-tree>
