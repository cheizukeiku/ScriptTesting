<?xml version="1.0" encoding="UTF-8"?>
<flexsim-tree version="4" treetype="distributed">
<node f="10000042" dt="4"><name>E Gate 4_2</name><data>
 <node f="40"><name></name></node>
 <node f="42"><name>superclasses</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>FlexSimObject</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>classes</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>People::Location</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>variables</name>
  <node f="80000040"><name></name></node>
  <node f="42" dt="2"><name>enterInstructions</name><data>MAIN:/project/library/people/Objects/Location&gt;behaviour/eventfunctions/configs/Kiosk/enterInstructions</data>
   <node f="40"><name></name></node></node>
  <node f="42" dt="2"><name>exitInstructions</name><data>MAIN:/project/library/people/Objects/Location&gt;behaviour/eventfunctions/configs/Kiosk/exitInstructions</data>
   <node f="40"><name></name></node></node>
  <node f="42"><name>activeRoles</name></node>
  <node f="42"><name>animationKinematics</name></node>
  <node f="42" dt="1"><name>resetposition</name><data>000000003ff00000</data>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>0000000040340000</data></node>
   <node f="42" dt="1"><name></name><data>00000000c0470000</data></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name></name><data>0000000080000000</data></node>
   <node f="42" dt="1"><name></name><data>0000000040468000</data></node>
   <node f="42" dt="1"><name></name><data>70a3d70a3fd70a3d</data></node>
   <node f="42" dt="1"><name></name><data>28f5c28f3fe28f5c</data></node>
   <node f="42" dt="1"><name></name><data>9999999a3ff99999</data></node>
   <node f="42" dt="3"><name></name><data><coupling>null</coupling></data></node>
  </node>
  <node f="42"><name>timetables</name></node>
  <node f="42"><name>networknodes</name></node>
  <node f="42" dt="1"><name>timeoflaststop</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>nrofstops</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>statebeforestop</name><data>0000000000000000</data></node>
  <node f="42"><name>collisionspheres</name></node>
  <node f="42"><name>collisionobjects</name></node>
  <node f="42" dt="1"><name>savedstate</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>doanimations</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>drawBox</name><data>0000000000000000</data></node>
  <node f="200000042"><name>onRelease</name>
   <node f="40"><name></name></node></node>
  <node f="200000042"><name>onEntry</name>
   <node f="40"><name></name></node></node>
  <node f="200000042"><name>onExit</name>
   <node f="40"><name></name></node></node>
  <node f="42" dt="3"><name>ResourceInfo</name><data><coupling>null</coupling></data></node>
  <node f="42"><name>PeopleAsset</name></node>
  <node f="442" dt="2"><name>onSimulationStart</name><data>Object current = ownerobject(c);
{ // ************* PickOption Start ************* //
/***popup:SetObjectColor*/
/**Set Object Color*/
Object object = /** \nObject: *//***tag:object*//**/current/**/;
object.color = /** \nColor: *//***tag:color*/ /**/Color(0.13, 0.26, 0.44)/**/;
} // ******* PickOption End ******* //
</data></node>
  <node f="442" dt="2"><name>resettrigger</name><data>Object current = ownerobject(c);
{ // ************* PickOption Start ************* //
/***popup:SetObjectColor*/
/**Set Object Color*/
Object object = /** \nObject: *//***tag:object*//**/current/**/;
object.color = /** \nColor: *//***tag:color*/ /**/Color(0.13, 0.26, 0.44)/**/;
} // ******* PickOption End ******* //
</data></node>
 </node>
 <node f="42"><name>spatial</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>spatialx</name><data>0000000040340000</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>00000000c0470000</data></node>
  <node f="42" dt="1"><name>spatialz</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialsx</name><data>70a3d70a3fd70a3d</data></node>
  <node f="42" dt="1"><name>spatialsy</name><data>28f5c28f3fe28f5c</data></node>
  <node f="42" dt="1"><name>spatialsz</name><data>9999999a3ff99999</data></node>
  <node f="42" dt="1"><name>spatialrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialry</name><data>0000000080000000</data></node>
  <node f="42" dt="1"><name>spatialrz</name><data>0000000040468000</data></node>
  <node f="42" dt="1"><name>offsetx</name><data>000000003fe00000</data></node>
  <node f="42" dt="1"><name>offsety</name><data>147ae1483fff47ae</data></node>
  <node f="42" dt="1"><name>offsetz</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetsx</name><data>70a3d70a40050a3d</data></node>
  <node f="42" dt="1"><name>offsetsy</name><data>b851eb853ff7851e</data></node>
  <node f="42" dt="1"><name>offsetsz</name><data>28f5c28f3fe28f5c</data></node>
  <node f="42" dt="1"><name>offsetrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetrz</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>centroid</name><data>000000003ff00000</data></node>
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
    <entry><ed>idle</ed><ed>0000000000000000</ed><ed>1</ed></entry>
    <entry><ed>processing</ed><ed>0000000000000000</ed><ed>1</ed></entry>
    <entry><ed>busy</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>blocked</ed><ed>0000000000000000</ed><ed>1</ed></entry>
    <entry><ed>generating</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>empty</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>collecting</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>releasing</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>waiting for operator</ed><ed>0000000000000000</ed><ed>1</ed></entry>
    <entry><ed>waiting for transport</ed><ed>0000000000000000</ed><ed>1</ed></entry>
    <entry><ed>breakdown</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>scheduled down</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>conveying</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>travel empty</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>travel loaded</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>offset travel empty</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>offset travel loaded</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>loading</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>unloading</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>down</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>setup</ed><ed>0000000000000000</ed><ed>1</ed></entry></data></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>0000000040100000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42"><name>state_profiles</name>
   <node f="40"><name></name></node>
   <node f="42" dt="7"><name>Availability</name><data/>
    <node f="40"><name></name></node>
    <node f="42" dt="6"><name>profile</name><data f="1">
     <fields>
      <field name="state" bytesize="36" type="259"/>
      <field name="time" bytesize="8" type="1"/>
      <field name="active" bytesize="4" type="2"/>
     </fields>
     <entry><ed>Available</ed><ed>0000000000000000</ed><ed>1</ed></entry>
     <entry><ed>Acquired</ed><ed>0000000000000000</ed><ed>1</ed></entry>
     <entry><ed>Unavailable</ed><ed>0000000000000000</ed><ed>0</ed></entry></data></node>
    <node f="210000042"><name>onChange</name>
     <node f="40"><name></name></node>
     <node f="210000042" dt="3"><name></name><data><coupling>/E Gate 4_2&gt;stats/HC_Availability_States/dependencies/_2</coupling></data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>sdt::attributetree</name><data>ComboStateChangeEvent</data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name>time</name><data>0000000000000000</data></node>
       <node f="42" dt="3"><name>involved</name><data><coupling>/E Gate 4_2&gt;stats/state_profiles/Availability/onChange</coupling></data></node>
       <node f="42" dt="1"><name>code</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>eventcounter</name><data>0000000000000000</data></node>
       <node f="42" dt="2"><name>data</name><data storagetype="hexadecimal">0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>type</name><data>0000000040100000</data></node>
     <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
    </node>
   </node>
   <node f="42" dt="7"><name>HC States</name><data/>
    <node f="40"><name></name></node>
    <node f="42" dt="6"><name>profile</name><data f="1">
     <fields>
      <field name="state" bytesize="36" type="259"/>
      <field name="time" bytesize="8" type="1"/>
      <field name="active" bytesize="4" type="2"/>
     </fields>
     <entry><ed>Idle</ed><ed>0000000000000000</ed><ed>1</ed></entry>
     <entry><ed>Occupied</ed><ed>0000000000000000</ed><ed>1</ed></entry></data></node>
    <node f="210000042"><name>onChange</name>
     <node f="40"><name></name></node>
     <node f="210000042" dt="3"><name></name><data><coupling>/E Gate 4_2&gt;stats/HC_Availability_States/dependencies/_1</coupling></data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>sdt::attributetree</name><data>ComboStateChangeEvent</data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name>time</name><data>0000000000000000</data></node>
       <node f="42" dt="3"><name>involved</name><data><coupling>/E Gate 4_2&gt;stats/state_profiles/HC States/onChange</coupling></data></node>
       <node f="42" dt="1"><name>code</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>eventcounter</name><data>0000000000000000</data></node>
       <node f="42" dt="2"><name>data</name><data storagetype="hexadecimal">0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>type</name><data>0000000040100000</data></node>
     <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
    </node>
   </node>
  </node>
  <node f="42" dt="7"><name>HC_Availability_States</name><data/>
   <node f="40"><name></name></node>
   <node f="200042" dt="6"><name>profile</name><data f="1">
    <fields>
     <field name="state" bytesize="4" type="261"/>
     <field name="time" bytesize="8" type="1"/>
     <field name="active" bytesize="4" type="2"/>
    </fields>
    <entry><ed>1</ed><ed>0000000000000000</ed><ed>0</ed></entry>
    <entry><ed>3</ed><ed>0000000000000000</ed><ed>0</ed></entry><varchar>other</varchar><varchar>1</varchar><varchar>Idle_Available</varchar><varchar>2</varchar><varchar>Idle_Acquired</varchar><varchar>3</varchar><varchar>Occupied_Acquired</varchar><varchar>4</varchar><varchar>Occupied_Available</varchar></data></node>
   <node f="42"><name>dependencies</name>
    <node f="40"><name></name></node>
    <node f="10000042" dt="3"><name>_1</name><data><coupling>/E Gate 4_2&gt;stats/state_profiles/HC States/onChange/1</coupling></data></node>
    <node f="10000042" dt="3"><name>_2</name><data><coupling>/E Gate 4_2&gt;stats/state_profiles/Availability/onChange/1</coupling></data></node>
   </node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>00000000401c0000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000040400000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulative</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulativeTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>minValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>maxValue</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>numEntries</name><data>0000000040080000</data></node>
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
   <node f="200000042"><name>onChange</name>
    <node f="40"><name></name></node></node>
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
  <node f="42" dt="2"><name>title</name><data>Location</data></node>
  <node f="42" dt="2"><name>description</name><data></data></node>
  <node f="42" dt="2"><name>guifocusclass</name><data>VIEW:/standardviews/modelingutilities/QuickerProperties</data></node>
  <node f="42" dt="2"><name>tooltip</name><data>A location for people to go to</data></node>
 </node>
 <node f="42"><name>objectinfo</name>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>Availability:  Available</name><data>Available</data></node>
  <node f="42" dt="2"><name>State:  Idle</name><data>Idle</data></node>
 </node>
 <node f="42"><name>labels</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Owner</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="1"><name>Priority</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>Preemptable</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>linenumber</name><data>0000000040100000</data></node>
 </node>
 <node f="42"><name>visual</name>
  <node f="40"><name></name></node>
  <node f="42"><name>color</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name>red</name><data>0a3d70a43fc0a3d7</data></node>
   <node f="42" dt="1"><name>green</name><data>0a3d70a43fd0a3d7</data></node>
   <node f="42" dt="1"><name>blue</name><data>c28f5c293fdc28f5</data></node>
  </node>
  <node f="42" dt="2"><name>shape</name><data>modules\People\shapes\locations\kiosk.fbx</data></node>
  <node f="42" dt="1"><name>shapeindex</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>picture</name><data>modules\People\bitmaps\locations\chairsmall.png</data></node>
  <node f="42" dt="2"><name>imageobject</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexobject</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imagebase</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexbase</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>frame</name><data>0000000000000000</data></node>
 </node>
 <node f="4000000042" dt="2"><name>windowtitle</name><data>Location</data>
  <node f="40"><name></name></node></node>
 <node f="42"><name>connections</name>
  <node f="40"><name></name></node>
  <node f="42"><name>connectionsin</name>
   <node f="40"><name></name></node></node>
  <node f="42"><name>connectionsout</name>
   <node f="40"><name></name></node></node>
  <node f="42"><name>connectionscenter</name>
   <node f="40"><name></name></node>
   <node f="10000042" dt="3"><name></name><data><coupling>/WaitingLine14&gt;connections/connectionscenter/_2</coupling></data>
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
 <node f="42"><name>stored</name>
  <node f="40"><name></name></node>
  <node f="800000042" dt="2"><name>PeopleFlow</name><data>/Tools/People/Flows/InstancedFlows/Location</data>
   <node f="40"><name></name></node>
   <node f="42"><name>blackBox</name>
    <node f="40"><name></name></node>
    <node f="2000000042"><name>Maintenance Condition</name>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>value</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>type</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>user</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>local</name><data>000000003ff00000</data></node>
     <node f="42" dt="2"><name>codeHeader</name><data>Object current = param(1);
treenode activity = param(2);
Token token = param(3);
Variant assignTo = param(4);
string labelName = param(5);
treenode processFlow = ownerobject(activity);
</data></node>
     <node f="42" dt="2"><name>picklistPath</name><data>VIEW:/modules/ProcessFlow/picklists/assignLabels</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name></name><data>../../../../../../..&gt;variables/removeLabel</data></node>
     </node>
     <node f="42" dt="2"><name></name><data>/Tools/People/Flows/InstancedFlows/Location&gt;variables/blackBox/Maintenance Condition</data></node>
    </node>
    <node f="2000000042"><name>Maintenance Time</name>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>value</name><data>0000000040240000</data>
      <node f="40" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>FlexScriptCode</data>
        <node f="40"><name></name></node></node>
      </node></node>
     <node f="42" dt="1"><name>type</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>user</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>local</name><data>000000003ff00000</data></node>
     <node f="42" dt="2"><name>codeHeader</name><data>Object current = param(1);
treenode activity = param(2);
Token token = param(3);
Variant assignTo = param(4);
string labelName = param(5);
treenode processFlow = ownerobject(activity);
</data></node>
     <node f="42" dt="2"><name>picklistPath</name><data>VIEW:/modules/ProcessFlow/picklists/assignLabels</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name></name><data>../../../../../../..&gt;variables/removeLabel</data></node>
     </node>
     <node f="42" dt="2"><name></name><data>/Tools/People/Flows/InstancedFlows/Location&gt;variables/blackBox/Maintenance Time</data></node>
    </node>
    <node f="2000000042"><name>Maintenance Staff</name>
     <node f="40"><name></name></node>
     <node f="42"><name>value</name>
      <node f="40" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>FlexScriptCode</data>
        <node f="40"><name></name></node></node>
      </node></node>
     <node f="42" dt="1"><name>type</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>user</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>local</name><data>000000003ff00000</data></node>
     <node f="42" dt="2"><name>codeHeader</name><data>Object current = param(1);
treenode activity = param(2);
Token token = param(3);
Variant assignTo = param(4);
string labelName = param(5);
treenode processFlow = ownerobject(activity);
</data></node>
     <node f="42" dt="2"><name>picklistPath</name><data>VIEW:/modules/ProcessFlow/picklists/assignLabels</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name></name><data>../../../../../../..&gt;variables/removeLabel</data></node>
     </node>
     <node f="42" dt="2"><name></name><data>/Tools/People/Flows/InstancedFlows/Location&gt;variables/blackBox/Maintenance Staff</data></node>
    </node>
    <node f="2000000042"><name>Maintenance Equipment</name>
     <node f="40"><name></name></node>
     <node f="42"><name>value</name></node>
     <node f="42" dt="1"><name>type</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>user</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>local</name><data>000000003ff00000</data></node>
     <node f="42" dt="2"><name>codeHeader</name><data>Object current = param(1);
treenode activity = param(2);
Token token = param(3);
Variant assignTo = param(4);
string labelName = param(5);
treenode processFlow = ownerobject(activity);
</data></node>
     <node f="42" dt="2"><name>picklistPath</name><data>VIEW:/modules/ProcessFlow/picklists/assignLabels</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name></name><data>../../../../../../..&gt;variables/removeLabel</data></node>
     </node>
     <node f="42" dt="2"><name></name><data>/Tools/People/Flows/InstancedFlows/Location&gt;variables/blackBox/Maintenance Equipment</data></node>
    </node>
   </node>
  </node>
 </node>
 <node f="42"><name>Groups</name>
  <node f="40"><name></name></node>
  <node f="810000042" dt="3"><name>_1</name><data><coupling>/Tools/Groups/Locations/_27</coupling></data>
   <node f="40"><name></name></node></node>
  <node f="810000042" dt="3"><name>_2</name><data><coupling>/Tools/Groups/E Gates Part 2/_4</coupling></data></node>
 </node>
 <node f="42"><name>WaitingBackorders</name>
  <node f="40"><name></name></node></node>
 <node f="42"><name>ActiveProcesses</name>
  <node f="40"><name></name></node></node>
</data>
 <node f="40"><name></name></node></node></flexsim-tree>
