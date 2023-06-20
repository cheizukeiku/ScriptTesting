<?xml version="1.0" encoding="UTF-8"?>
<flexsim-tree version="4" treetype="distributed">
<node f="62" dt="4"><name>StraightConveyor1</name><data>
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
  <node f="42" dt="1"><name>length</name><data>008295ff40285c7e</data></node>
  <node f="42" dt="1"><name>rise</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>useVirtualLength</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>virtualLength</name><data>0000000040240000</data></node>
  <node f="42"><name>system</name>
   <node f="40"><name></name></node>
   <node f="42" dt="3"><name></name><data><coupling>/ConveyorSystem&gt;variables/conveyors/_1</coupling></data></node>
  </node>
  <node f="42"><name>motor</name></node>
  <node f="42" dt="3"><name>visualization</name><data><coupling>/ConveyorSystem&gt;variables/visualizations/BeltConveyor</coupling></data></node>
  <node f="42" dt="1"><name>width</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>rollerAngle</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>speed</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>conveyorPoints</name><data>0000000000000000</data>
   <node f="40"><name></name></node>
   <node f="42" dt="3"><name>_1</name><data><coupling>/EntryTransfer1&gt;variables/transferPoint/1</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>distAlong</name><data>0000000000000000</data></node>
    <node f="42" dt="3"><name>system</name><data><coupling>/ConveyorSystem&gt;variables/conveyorPoints/_1</coupling></data></node>
    <node f="42" dt="1"><name>distOffCenter</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>rangeWidth</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>isAtSide</name><data>000000003ff00000</data></node>
   </node>
   <node f="42" dt="3"><name>_2</name><data><coupling>/EntryTransfer2&gt;variables/transferPoint/1</coupling></data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>distAlong</name><data>57566f7c401be0f9</data></node>
    <node f="42" dt="3"><name>system</name><data><coupling>/ConveyorSystem&gt;variables/conveyorPoints/_5</coupling></data></node>
    <node f="42" dt="1"><name>distOffCenter</name><data>000000003fe00000</data></node>
    <node f="42" dt="1"><name>rangeWidth</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>isAtSide</name><data>000000003ff00000</data></node>
   </node>
   <node f="42" dt="3"><name>_3</name><data><coupling>/CurvedConveyor1&gt;variables/conveyorPoints/_1</coupling></data>
    <node f="40"><name></name></node>
    <node f="42"><name>allocations</name></node>
    <node f="42"><name>allocationRequests</name></node>
    <node f="42" dt="1"><name>distAlong</name><data>008295ff40285c7e</data></node>
    <node f="42" dt="3"><name>system</name><data><coupling>/ConveyorSystem&gt;variables/conveyorPoints/_11</coupling></data></node>
    <node f="42" dt="1"><name>distOffCenter</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>transferAngle</name><data>0000000000000000</data></node>
    <node f="42" dt="3"><name>type</name><data><coupling>/ConveyorSystem&gt;variables/transferTypes/TransferType1</coupling></data></node>
    <node f="42"><name>massFlowTransfer</name></node>
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
  <node f="42" dt="1"><name>spatialx</name><data>636a32014036e542</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>00000000c0398000</data></node>
  <node f="42" dt="1"><name>spatialz</name><data>000000003fe00000</data></node>
  <node f="42" dt="1"><name>spatialsx</name><data>008295ff40285c7e</data></node>
  <node f="42" dt="1"><name>spatialsy</name><data>000000003fe00000</data></node>
  <node f="42" dt="1"><name>spatialsz</name><data>a00000003fc99999</data></node>
  <node f="42" dt="1"><name>spatialrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialrz</name><data>0000000000000000</data></node>
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
  </node>
  <node f="42" dt="7"><name>stats_input</name><data/>
   <node f="40"><name></name></node></node>
  <node f="42" dt="7"><name>stats_output</name><data/>
   <node f="40"><name></name></node></node>
  <node f="42" dt="7"><name>stats_content</name><data/>
   <node f="40"><name></name></node></node>
  <node f="42" dt="7"><name>stats_staytime</name><data/>
   <node f="40"><name></name></node></node>
  <node f="42" dt="1"><name>stats_creationtime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>stats_lastmovetime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>simLength</name><data>008295ff40285c7e</data></node>
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
  <node f="40"><name></name></node></node>
 <node f="42"><name>stored</name></node>
 <node f="42"><name>Groups</name>
  <node f="40"><name></name></node>
  <node f="800000042" dt="3"><name></name><data><coupling>/Tools/Groups/Conveyors/_1</coupling></data></node>
 </node>
</data>
 <node f="40"><name></name></node></node></flexsim-tree>
