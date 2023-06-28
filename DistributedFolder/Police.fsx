<?xml version="1.0" encoding="UTF-8"?>
<flexsim-tree version="4" treetype="distributed">
<node f="10000042" dt="4"><name>Police 1</name><data>
 <node f="40"><name></name></node>
 <node f="42"><name>superclasses</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Operator</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>classes</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>People::Staff</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>variables</name>
  <node f="80000040"><name></name></node>
  <node f="42" dt="1"><name>resetposition</name><data>000000003ff00000</data>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>0000000040280000</data></node>
   <node f="42" dt="1"><name></name><data>00000000c0408000</data></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name></name><data>0000000080000000</data></node>
   <node f="42" dt="1"><name></name><data>0000000040468000</data></node>
   <node f="42" dt="1"><name></name><data>a00000003fd99999</data></node>
   <node f="42" dt="1"><name></name><data>200000003fe28f5c</data></node>
   <node f="42" dt="1"><name></name><data>400000003ffc7ae1</data></node>
   <node f="42" dt="3"><name></name><data><coupling>null</coupling></data></node>
  </node>
  <node f="42"><name>activeRoles</name></node>
  <node f="42" dt="1"><name>currentLocation</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>idleAnimation</name><data>Stand</data></node>
  <node f="42" dt="2"><name>walkAnimation</name><data>Walk</data></node>
  <node f="42" dt="2"><name>walkLoadedAnimation</name><data>WalkLoaded</data></node>
  <node f="42" dt="1"><name>maxcontent</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>loadtime</name><data>0000000000000000</data>
   <node f="40"><name></name></node></node>
  <node f="42" dt="1"><name>unloadtime</name><data>0000000000000000</data>
   <node f="40"><name></name></node></node>
  <node f="42" dt="1"><name>maxspeed</name><data>0000000040000000</data></node>
  <node f="42" dt="1"><name>acceleration</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>deceleration</name><data>000000003ff00000</data></node>
  <node f="42"><name>navigator</name>
   <node f="40"><name></name></node>
   <node f="810000042" dt="3"><name></name><data><coupling>/DefaultNavigator&gt;variables/travelmembers/_5</coupling></data>
    <node f="40"><name></name></node></node>
  </node>
  <node f="8000000442" dt="2"><name>breakto</name><data>TaskSequence activeTaskSequence = param(1);
TaskExecuter current = ownerobject(c);
/***popup:BreakToSame*/
/**New Tasksequences Only*/
/** Only break to task sequences that have not been started already.*/
/** Object queueing the tasksequences: */
Dispatcher theObject = /***tag:dispatcher*//**/current/**/;

TaskSequence returnts = NULL;
for (int index = 1; index &lt;= theObject.taskSequences.length &amp;&amp; ! returnts; index++) {
	TaskSequence curts = theObject.taskSequences[index];
	if (gettotalnroftasks(curts) == getnroftasks(curts))
		returnts = curts;
}
return returnts;</data></node>
  <node f="42" dt="1"><name>modifyrotation</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>useoffsets</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>offsettingnow</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetbegintime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsettotaltime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>loadedspeed</name><data>0000000040000000</data></node>
  <node f="42" dt="1"><name>emptyspeed</name><data>0000000040000000</data></node>
  <node f="42" dt="1"><name>curloadunloadtime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>lastupdatedspeed</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>travelvstart</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>travelvend</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>lastspeedupdatetime</name><data>00000000bff00000</data></node>
  <node f="42" dt="2"><name>collisiontrigger</name><data>TaskExecuter current = ownerobject(c);
TaskExecuter otherobject = param(1);
treenode thissphere = param(2);
treenode othersphere = param(3);
TaskExecuter thisobject = current;
</data></node>
  <node f="42" dt="1"><name>collcheckinterval</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>drawcollspheres</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>incollision</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>collcheckstate</name><data>0000000000000000</data></node>
  <node f="42" dt="7"><name>totaltraveldist</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42"><name>kinematics</name></node>
  <node f="42" dt="1"><name>flipthreshold</name><data>0000000040668000</data></node>
  <node f="42" dt="1"><name>availableonstart</name><data>000000003ff00000</data></node>
  <node f="42"><name>activetasksequence</name></node>
  <node f="42"><name>tasksequencequeue</name></node>
  <node f="42"><name>coordinatedtasks</name></node>
  <node f="42" dt="1"><name>passimmediately</name><data>0000000000000000</data>
   <node f="40"><name></name></node></node>
  <node f="8000000442" dt="2"><name>passto</name><data>TaskSequence taskSequence = param(1);
Dispatcher current = ownerobject(c);
/**First Available*/
return 0;
</data></node>
  <node f="8000000442" dt="2"><name>queuestrategy</name><data>TaskSequence taskSequence = param(1);
Dispatcher current = ownerobject(c);
/**Sort by TaskSequence Priority*/

return taskSequence.priority;</data></node>
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
  <node f="42" dt="3"><name>ResourceInfo</name><data><coupling>null</coupling></data></node>
  <node f="42"><name>PeopleAsset</name></node>
 </node>
 <node f="42"><name>visual</name>
  <node f="40"><name></name></node>
  <node f="42"><name>color</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name>red</name><data>28f5c28f3fd28f5c</data></node>
   <node f="42" dt="1"><name>green</name><data>d70a3d713fe570a3</data></node>
   <node f="42" dt="1"><name>blue</name><data>0a3d70a43fe8a3d7</data></node>
  </node>
  <node f="42" dt="2"><name>picture</name><data>modules\People\bitmaps\staff\staffsmall.png</data></node>
  <node f="42" dt="2"><name>shape</name><data>fs3d\People\MaleEmergency\Male_Emergency.fbx</data></node>
  <node f="42" dt="1"><name>shapeindex</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imageobject</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexobject</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imagebase</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexbase</name><data>0000000000000000</data></node>
  <node f="42"><name>drawsurrogate</name>
   <node f="40"><name></name></node></node>
  <node f="42"><name>resizeinfo</name>
   <node f="40"><name></name></node>
   <node f="42"><name>basesize</name>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>x</name><data>9999999a3fd99999</data></node>
    <node f="42" dt="1"><name>y</name><data>28f5c28f3fe28f5c</data></node>
    <node f="42" dt="1"><name>z</name><data>47ae147b3ffc7ae1</data></node>
   </node>
   <node f="42"><name>bodies</name>
    <node f="40"><name></name></node></node>
  </node>
  <node f="42" dt="1"><name>animationinfo</name><data>000000003ff00000</data>
   <node f="40"><name></name></node>
   <node f="42"><name>bodies</name>
    <node f="40"><name></name></node></node>
   <node f="42"><name>animations</name>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>Walk</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name></name><data>2367b75c4013ea57</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>Walk_Male</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>2367b75c4013ea57</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\Walk_Male.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>WalkLoaded</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name></name><data>2367b75c4013ea57</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040000000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>Carry</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>2367b75c4013ea57</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\WalkLoaded_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>Stand</name><data>000000003ff00000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>4cc20b513fe1fa3f</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name></name><data>000000003ff00000</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040080000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>Idle</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>000000003ff00000</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\Stand_Male.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>SitDown</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040180000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>3d70a3d74001d70a</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040100000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>SitDown</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>3d70a3d74001d70a</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\SitDown_Male.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>SitDown2</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040180000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>a3d70a3d40043d70</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040140000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>SitDown2</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>a3d70a3d40043d70</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\SitDown2_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>SitIdle</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>000000003ff00000</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040180000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>SittingIdle1</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>000000003ff00000</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\SitIdle_Male.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>SitIdle2</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>54af3589401bbdcf</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000401c0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>Sitting2</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>54af3589401bbdcf</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\SitIdle2_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>StandUp</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>94ed8175400156a1</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040200000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>StandUp</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>94ed8175400156a1</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\StandUp_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>LayDown</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040180000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>eb851eb84016b851</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040220000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>LayingDown</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>eb851eb84016b851</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\LayDown_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>LayIdle</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>2f870566400008a4</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040240000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>LayIdle_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>2f870566400008a4</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\LayIdle_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>LayIdle2</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>0ed5b098402f0150</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040260000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>LayIdle2_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>0ed5b098402f0150</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\LayIdle2_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>StandFromLaying</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>8d9741db400ff840</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040280000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>StandFromLaying_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>8d9741db400ff840</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\StandFromLaying_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>Wheelchair</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>d078fa994007f75b</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040320000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>WheelchairSelfPropelling_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>d078fa994007f75b</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\WheelchairSelfPropelling_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>PushCart</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>519aa7283fff96b4</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>Armature|Push Cart</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000403f0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>Clip1</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>519aa7283fff96b4</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\PushCart_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>PushWheelchair</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>2f870566400008a4</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>Armature|Armature|mixamo.com|Layer0</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040400000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>Clip1</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>2f870566400008a4</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\PushWheelchair_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>Shrug</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>1377b9eb3fffc1b4</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000402a0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>Shrug_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>1377b9eb3fffc1b4</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\Shrug_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>EnterCode</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>a579ac4a401dee7a</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000402c0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>EnterCode_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>a579ac4a401dee7a</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\EnterCode_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>SitToType</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>000000003ff00000</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000402e0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>SitToType_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>000000003ff00000</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\SitToType_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>Typing</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>1838fe9440306437</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040300000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>Typing_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>1838fe9440306437</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\Typing_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>TypeToSit</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>6a63bd823fe8ef60</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040310000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>TypeToSit_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>6a63bd823fe8ef60</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\TypeToSit_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>WalkWithWalker</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>9999999a400d9999</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040330000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>WalkWithWalker_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>9999999a400d9999</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\WalkWithWalker_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>WalkInjured</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>9999999a3ff19999</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040340000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>WalkInjured_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>9999999a3ff19999</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\WalkInjured_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>WalkWithIV</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>978d4fdf3ff9126e</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040350000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>WalkWithIV_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>978d4fdf3ff9126e</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\WalkWithIV_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>WalkWithBriefcase</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>978d4fdf3ff1126e</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040360000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>WalkWithBriefcase_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>978d4fdf3ff1126e</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\WalkWithBriefcase_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>DescendStairs</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>3126e9793ff2ac08</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040370000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>WalkDownStairs_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>3126e9793ff2ac08</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\WalkDownStairs_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>AscendStairs</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>645a1cac3ff5df3b</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040380000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>WalkUpStairs_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>645a1cac3ff5df3b</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\WalkUpStairs_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>Picking</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>cccccccd4018cccc</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040390000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>Picking_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>cccccccd4018cccc</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\Picking_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>Open</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>0000000040100000</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000403a0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>OpenCabinet_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>0000000040100000</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\OpenCloseCabinet_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>Close</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>0000000040140000</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000403a0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>CloseCabinet_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>0000000040000000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>0000000040140000</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\OpenCloseCabinet_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>TalkingOnPhone</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>c083126f401421ca</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000403b0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>TalkingOnPhone_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>c083126f401421ca</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\TalkingOnPhone_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>UseTablet</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>d2f1a9fc4027224d</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000403c0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>StandingUsingTouchscreen_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>d2f1a9fc4027224d</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\StandingUsingTouchscreen_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>FaxMachine</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>33333333402a3333</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000403d0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>SendingFax_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>33333333402a3333</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\SendingFax_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>ShakeHands</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>d916872b401177ce</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000403e0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>ShakingHands_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>d916872b401177ce</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\ShakingHands_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
   </node>
   <node f="42"><name></name></node>
  </node>
  <node f="42" dt="3"><name>shapedata</name><data><coupling>/Police 1&gt;visual/localshapedata/1</coupling></data></node>
  <node f="42"><name>localshapedata</name>
   <node f="40"><name></name></node>
   <node f="10000042"><name></name>
    <node f="40"><name></name></node>
    <node f="42" dt="7"><name>Body</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>textureName</name><data>fs3d\People\Textures\Skin\MaleScan2\MaleScan2.png</data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000040554000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Body</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>000000003ff00000</data></node>
     <node f="42" dt="2"><name>textureName</name><data>fs3d\People\Textures\Skin\MaleScan2\MaleScan2.png</data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000040554000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Hat_Male_Fit_A_Captain_Hat</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040000000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Shoes_Male_Fit_A_Firefighter_Boots</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040080000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Hat_Male_Fit_A_Tactical_Response</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040100000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Hat_Male_Fit_A_Police_Cap</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040140000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Hair_Male_Fit_A_Alpha_Short_Hair</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040180000</data></node>
     <node f="42" dt="2"><name>textureName</name><data>fs3d\People\Textures\Hair\Male_Short\Hair_MaleFitA_AlphaShortHair.png</data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>00000000401c0000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>5c5c5c5c3fdc5c5c</data></node>
       <node f="42" dt="1"><name></name><data>d8d8d8d93fd8d8d8</data></node>
       <node f="42" dt="1"><name></name><data>969696973fd69696</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Gloves_Male_Fit_A_Combat_Gloves</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>00000000401c0000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Shoes_Male_Fit_A_Boots</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040200000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Head_Male_Blue</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040220000</data></node>
     <node f="42" dt="2"><name>textureName</name><data>fs3d\People\Textures\Skin\MaleScan2\MaleScan2.png</data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000040554000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Hat_Male_Fit_A_Hard_Hat</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040240000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Shoes_Male_Fit_A_Short_Boot</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040260000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Bottom_Male_Fit_A_Police_Uniform</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040280000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Hat_Male_Fit_A_Baseball_Cap</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>00000000402a0000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Bottom_Male_Fit_A_Fire_Fighter_Pants</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>00000000402c0000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Hat_Male_Fit_A_Hat_And_Headphones</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>00000000402e0000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Bottom_Male_Fit_A_Tactical_Response</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040300000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Shoes_Male_Fit_A_Tactical_Boot_B</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040310000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Head_Male_Red</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040320000</data></node>
     <node f="42" dt="2"><name>textureName</name><data>fs3d\People\Textures\Skin\MaleScan2\MaleScan2.png</data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000040554000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Beard_And_Moustache</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040330000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Moustaches</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040340000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Bottom_Male_Fit_A_Belted_Straight_Pant</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040350000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Top_Male_Fit_A_Tactical_Shirt</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040360000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Top_Male_Fit_A_Fire_Fighter_Jacket</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040370000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Beards</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040380000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>cccccccd3feccccc</data></node>
       <node f="42" dt="1"><name></name><data>cccccccd3feccccc</data></node>
       <node f="42" dt="1"><name></name><data>cccccccd3feccccc</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Top_Male_Fit_A_Tactical_Response</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040390000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Masks</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>00000000403a0000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Eyewear</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>00000000403b0000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Mask_Male_Fit_A_Surgical_Mask</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>00000000403c0000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Top_Male_Fit_A_Relaxed_V_NecK_Tee</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>00000000403d0000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>5c28f5c23fd5c28f</data></node>
       <node f="42" dt="1"><name></name><data>d70a3d713fdd70a3</data></node>
       <node f="42" dt="1"><name></name><data>5c28f5c23fe3c28f</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Glasses_Male_Fit_A_Classic_A</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>00000000403e0000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Top_Male_Fit_A_Long_Sleeve_Police_Uniform</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>00000000403f0000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Hat_Male_Fit_A_Fire_Fighter_Helmet</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040400000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Glasses_Male_Fit_A_Goggles_A</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040408000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Gloves_Male_Fit_A_Fingerless_Gloves</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040410000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>5c28f5c23fd5c28f</data></node>
       <node f="42" dt="1"><name></name><data>5c28f5c23fd5c28f</data></node>
       <node f="42" dt="1"><name></name><data>5c28f5c23fd5c28f</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
   </node>
  </node>
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
    <node f="42" dt="1"><name>curValue</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulative</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulativeTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>minValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>maxValue</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>numEntries</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>lastSetTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>rate</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>lastResetTime</name><data>0000000000000000</data></node>
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
     <node f="210000042" dt="3"><name></name><data><coupling>/Police 1&gt;stats/HC_Availability_States/dependencies/_2</coupling></data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>sdt::attributetree</name><data>ComboStateChangeEvent</data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name>time</name><data>0000000000000000</data></node>
       <node f="42" dt="3"><name>involved</name><data><coupling>/Police 1&gt;stats/state_profiles/Availability/onChange</coupling></data></node>
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
     <entry><ed>ProvidingCare</ed><ed>0000000000000000</ed><ed>1</ed></entry></data></node>
    <node f="210000042"><name>onChange</name>
     <node f="40"><name></name></node>
     <node f="210000042" dt="3"><name></name><data><coupling>/Police 1&gt;stats/HC_Availability_States/dependencies/_1</coupling></data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>sdt::attributetree</name><data>ComboStateChangeEvent</data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name>time</name><data>0000000000000000</data></node>
       <node f="42" dt="3"><name>involved</name><data><coupling>/Police 1&gt;stats/state_profiles/HC States/onChange</coupling></data></node>
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
    <entry><ed>3</ed><ed>0000000000000000</ed><ed>0</ed></entry><varchar>other</varchar><varchar>1</varchar><varchar>Idle_Available</varchar><varchar>2</varchar><varchar>Idle_Acquired</varchar><varchar>3</varchar><varchar>ProvidingCare_Acquired</varchar><varchar>4</varchar><varchar>ProvidingCare_Available</varchar></data></node>
   <node f="42"><name>dependencies</name>
    <node f="40"><name></name></node>
    <node f="10000042" dt="3"><name>_1</name><data><coupling>/Police 1&gt;stats/state_profiles/HC States/onChange/1</coupling></data></node>
    <node f="10000042" dt="3"><name>_2</name><data><coupling>/Police 1&gt;stats/state_profiles/Availability/onChange/1</coupling></data></node>
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
  <node f="42" dt="1"><name>stats_creationtime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>stats_lastmovetime</name><data>0000000000000000</data></node>
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
  <node f="42" dt="1"><name>lastPickPlaceOffsetResult</name><data>0000000000000000</data></node>
 </node>
 <node f="42"><name>special</name>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>title</name><data>Staff</data></node>
  <node f="42" dt="2"><name>description</name><data></data></node>
  <node f="42" dt="2"><name>tooltip</name><data>People</data></node>
  <node f="42" dt="2"><name>guifocusclass</name><data>VIEW:/standardviews/modelingutilities/QuickerProperties</data></node>
 </node>
 <node f="42"><name>labels</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Owner</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="1"><name>Priority</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>Preemptable</name><data>0000000000000000</data></node>
  <node f="42"><name>TravelingWithPatient</name></node>
 </node>
 <node f="42"><name>objectinfo</name>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>Availability:  Available</name><data>Available</data></node>
  <node f="42" dt="2"><name>State:  Idle</name><data>Idle</data></node>
 </node>
 <node f="4000000042" dt="2"><name>windowtitle</name><data>Staff</data>
  <node f="40"><name></name></node></node>
 <node f="42"><name>spatial</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>spatialx</name><data>0000000040280000</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>00000000c0408000</data></node>
  <node f="42" dt="1"><name>spatialz</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialsx</name><data>a00000003fd99999</data></node>
  <node f="42" dt="1"><name>spatialsy</name><data>200000003fe28f5c</data></node>
  <node f="42" dt="1"><name>spatialsz</name><data>400000003ffc7ae1</data></node>
  <node f="42" dt="1"><name>spatialrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialry</name><data>0000000080000000</data></node>
  <node f="42" dt="1"><name>spatialrz</name><data>0000000040468000</data></node>
  <node f="42" dt="1"><name>offsetx</name><data>000000003fe00000</data></node>
  <node f="42" dt="1"><name>offsety</name><data>000000003fe00000</data></node>
  <node f="42" dt="1"><name>offsetz</name><data>40000000bf847ae1</data></node>
  <node f="42" dt="1"><name>offsetsx</name><data>600000003f91b717</data></node>
  <node f="42" dt="1"><name>offsetsy</name><data>a00000003f999999</data></node>
  <node f="42" dt="1"><name>offsetsz</name><data>800000003f76f006</data></node>
  <node f="42" dt="1"><name>offsetrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetrz</name><data>0000000040568000</data></node>
  <node f="42" dt="1"><name>centroid</name><data>000000003ff00000</data></node>
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
 <node f="42"><name>stored</name>
  <node f="40"><name></name></node>
  <node f="800000042" dt="2"><name>PeopleFlow</name><data>/Tools/People/Flows/InstancedFlows/Staff</data>
   <node f="40"><name></name></node>
   <node f="42"><name>blackBox</name>
    <node f="40"><name></name></node>
    <node f="42"><name>Idle Location</name>
     <node f="40"><name></name></node>
     <node f="442" dt="2"><name>value</name><data>Object current = param(1);
treenode activity = param(2);
Token token = param(3);
Variant assignTo = param(4);
string labelName = param(5);
treenode processFlow = ownerobject(activity);

/**Staff's Reset Position*/

Array resetLocation = current.resetPosition.location;
Array resetRotation = current.resetPosition.rotation;

return resetLocation.append(resetRotation);
</data></node>
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
      <node f="42" dt="2"><name></name><data>../../../../../../../../..&gt;variables/removeLabel</data></node>
     </node>
     <node f="42" dt="2"><name></name><data>/Tools/People/Flows/InstancedFlows/Staff&gt;variables/blackBox/Idle Location</data></node>
    </node>
   </node>
  </node>
 </node>
 <node f="42"><name>Groups</name>
  <node f="40"><name></name></node>
  <node f="810000042" dt="3"><name>_1</name><data><coupling>/Tools/Groups/Staff/_7</coupling></data>
   <node f="40"><name></name></node></node>
  <node f="810000042" dt="3"><name>_2</name><data><coupling>/Tools/Groups/Departure Police/_1</coupling></data></node>
 </node>
 <node f="42"><name>ActiveProcesses</name>
  <node f="40"><name></name></node></node>
</data>
 <node f="40"><name></name></node></node>
<node f="10000042" dt="4"><name>Police 2</name><data>
 <node f="40"><name></name></node>
 <node f="42"><name>superclasses</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Operator</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>classes</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>People::Staff</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>variables</name>
  <node f="80000040"><name></name></node>
  <node f="42" dt="1"><name>resetposition</name><data>000000003ff00000</data>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>f6eb416e402f3386</data></node>
   <node f="42" dt="1"><name></name><data>00000000c0408000</data></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name></name><data>0000000080000000</data></node>
   <node f="42" dt="1"><name></name><data>000000004060e000</data></node>
   <node f="42" dt="1"><name></name><data>a00000003fd99999</data></node>
   <node f="42" dt="1"><name></name><data>200000003fe28f5c</data></node>
   <node f="42" dt="1"><name></name><data>400000003ffc7ae1</data></node>
   <node f="42" dt="3"><name></name><data><coupling>null</coupling></data></node>
  </node>
  <node f="42"><name>activeRoles</name></node>
  <node f="42" dt="1"><name>currentLocation</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>idleAnimation</name><data>Stand</data></node>
  <node f="42" dt="2"><name>walkAnimation</name><data>Walk</data></node>
  <node f="42" dt="2"><name>walkLoadedAnimation</name><data>WalkLoaded</data></node>
  <node f="42" dt="1"><name>maxcontent</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>loadtime</name><data>0000000000000000</data>
   <node f="40"><name></name></node></node>
  <node f="42" dt="1"><name>unloadtime</name><data>0000000000000000</data>
   <node f="40"><name></name></node></node>
  <node f="42" dt="1"><name>maxspeed</name><data>0000000040000000</data></node>
  <node f="42" dt="1"><name>acceleration</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>deceleration</name><data>000000003ff00000</data></node>
  <node f="42"><name>navigator</name>
   <node f="40"><name></name></node>
   <node f="810000042" dt="3"><name></name><data><coupling>/DefaultNavigator&gt;variables/travelmembers/_6</coupling></data>
    <node f="40"><name></name></node></node>
  </node>
  <node f="8000000442" dt="2"><name>breakto</name><data>TaskSequence activeTaskSequence = param(1);
TaskExecuter current = ownerobject(c);
/***popup:BreakToSame*/
/**New Tasksequences Only*/
/** Only break to task sequences that have not been started already.*/
/** Object queueing the tasksequences: */
Dispatcher theObject = /***tag:dispatcher*//**/current/**/;

TaskSequence returnts = NULL;
for (int index = 1; index &lt;= theObject.taskSequences.length &amp;&amp; ! returnts; index++) {
	TaskSequence curts = theObject.taskSequences[index];
	if (gettotalnroftasks(curts) == getnroftasks(curts))
		returnts = curts;
}
return returnts;</data></node>
  <node f="42" dt="1"><name>modifyrotation</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>useoffsets</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>offsettingnow</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetbegintime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsettotaltime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>loadedspeed</name><data>0000000040000000</data></node>
  <node f="42" dt="1"><name>emptyspeed</name><data>0000000040000000</data></node>
  <node f="42" dt="1"><name>curloadunloadtime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>lastupdatedspeed</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>travelvstart</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>travelvend</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>lastspeedupdatetime</name><data>00000000bff00000</data></node>
  <node f="42" dt="2"><name>collisiontrigger</name><data>TaskExecuter current = ownerobject(c);
TaskExecuter otherobject = param(1);
treenode thissphere = param(2);
treenode othersphere = param(3);
TaskExecuter thisobject = current;
</data></node>
  <node f="42" dt="1"><name>collcheckinterval</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>drawcollspheres</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>incollision</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>collcheckstate</name><data>0000000000000000</data></node>
  <node f="42" dt="7"><name>totaltraveldist</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>type</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42"><name>kinematics</name></node>
  <node f="42" dt="1"><name>flipthreshold</name><data>0000000040668000</data></node>
  <node f="42" dt="1"><name>availableonstart</name><data>000000003ff00000</data></node>
  <node f="42"><name>activetasksequence</name></node>
  <node f="42"><name>tasksequencequeue</name></node>
  <node f="42"><name>coordinatedtasks</name></node>
  <node f="42" dt="1"><name>passimmediately</name><data>0000000000000000</data>
   <node f="40"><name></name></node></node>
  <node f="8000000442" dt="2"><name>passto</name><data>TaskSequence taskSequence = param(1);
Dispatcher current = ownerobject(c);
/**First Available*/
return 0;
</data></node>
  <node f="8000000442" dt="2"><name>queuestrategy</name><data>TaskSequence taskSequence = param(1);
Dispatcher current = ownerobject(c);
/**Sort by TaskSequence Priority*/

return taskSequence.priority;</data></node>
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
  <node f="42" dt="3"><name>ResourceInfo</name><data><coupling>null</coupling></data></node>
  <node f="42"><name>PeopleAsset</name></node>
 </node>
 <node f="42"><name>visual</name>
  <node f="40"><name></name></node>
  <node f="42"><name>color</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name>red</name><data>28f5c28f3fd28f5c</data></node>
   <node f="42" dt="1"><name>green</name><data>d70a3d713fe570a3</data></node>
   <node f="42" dt="1"><name>blue</name><data>0a3d70a43fe8a3d7</data></node>
  </node>
  <node f="42" dt="2"><name>picture</name><data>modules\People\bitmaps\staff\staffsmall.png</data></node>
  <node f="42" dt="2"><name>shape</name><data>fs3d\People\MaleEmergency\Male_Emergency.fbx</data></node>
  <node f="42" dt="1"><name>shapeindex</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imageobject</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexobject</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imagebase</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexbase</name><data>0000000000000000</data></node>
  <node f="42"><name>drawsurrogate</name>
   <node f="40"><name></name></node></node>
  <node f="42"><name>resizeinfo</name>
   <node f="40"><name></name></node>
   <node f="42"><name>basesize</name>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>x</name><data>9999999a3fd99999</data></node>
    <node f="42" dt="1"><name>y</name><data>28f5c28f3fe28f5c</data></node>
    <node f="42" dt="1"><name>z</name><data>47ae147b3ffc7ae1</data></node>
   </node>
   <node f="42"><name>bodies</name>
    <node f="40"><name></name></node></node>
  </node>
  <node f="42" dt="1"><name>animationinfo</name><data>000000003ff00000</data>
   <node f="40"><name></name></node>
   <node f="42"><name>bodies</name>
    <node f="40"><name></name></node></node>
   <node f="42"><name>animations</name>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>Walk</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name></name><data>2367b75c4013ea57</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>Walk_Male</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>2367b75c4013ea57</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\Walk_Male.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>WalkLoaded</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name></name><data>2367b75c4013ea57</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040000000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>Carry</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>2367b75c4013ea57</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\WalkLoaded_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>Stand</name><data>000000003ff00000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>4cc20b513fe1fa3f</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name></name><data>000000003ff00000</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040080000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>Idle</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>000000003ff00000</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\Stand_Male.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>SitDown</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040180000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>3d70a3d74001d70a</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040100000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>SitDown</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>3d70a3d74001d70a</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\SitDown_Male.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>SitDown2</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040180000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>a3d70a3d40043d70</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040140000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>SitDown2</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>a3d70a3d40043d70</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\SitDown2_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>SitIdle</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>000000003ff00000</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040180000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>SittingIdle1</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>000000003ff00000</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\SitIdle_Male.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>SitIdle2</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>54af3589401bbdcf</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000401c0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>Sitting2</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>54af3589401bbdcf</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\SitIdle2_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>StandUp</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>94ed8175400156a1</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040200000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>StandUp</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>94ed8175400156a1</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\StandUp_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>LayDown</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040180000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>eb851eb84016b851</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040220000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>LayingDown</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>eb851eb84016b851</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\LayDown_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>LayIdle</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>2f870566400008a4</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040240000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>LayIdle_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>2f870566400008a4</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\LayIdle_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>LayIdle2</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>0ed5b098402f0150</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040260000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>LayIdle2_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>0ed5b098402f0150</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\LayIdle2_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>StandFromLaying</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>8d9741db400ff840</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040280000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>StandFromLaying_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>8d9741db400ff840</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\StandFromLaying_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>Wheelchair</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>d078fa994007f75b</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040320000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>WheelchairSelfPropelling_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>d078fa994007f75b</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\WheelchairSelfPropelling_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>PushCart</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>519aa7283fff96b4</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>Armature|Push Cart</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000403f0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>Clip1</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>519aa7283fff96b4</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\PushCart_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>PushWheelchair</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>2f870566400008a4</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>Armature|Armature|mixamo.com|Layer0</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040400000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>Clip1</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>2f870566400008a4</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\PushWheelchair_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>Shrug</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>1377b9eb3fffc1b4</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000402a0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>Shrug_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>1377b9eb3fffc1b4</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\Shrug_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>EnterCode</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>a579ac4a401dee7a</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000402c0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>EnterCode_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>a579ac4a401dee7a</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\EnterCode_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>SitToType</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>000000003ff00000</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000402e0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>SitToType_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>000000003ff00000</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\SitToType_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>Typing</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>1838fe9440306437</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040300000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>Typing_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>1838fe9440306437</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\Typing_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>TypeToSit</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>6a63bd823fe8ef60</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040310000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>TypeToSit_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>6a63bd823fe8ef60</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\TypeToSit_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>WalkWithWalker</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>9999999a400d9999</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040330000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>WalkWithWalker_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>9999999a400d9999</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\WalkWithWalker_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>WalkInjured</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>9999999a3ff19999</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040340000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>WalkInjured_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>9999999a3ff19999</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\WalkInjured_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>WalkWithIV</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>978d4fdf3ff9126e</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040350000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>WalkWithIV_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>978d4fdf3ff9126e</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\WalkWithIV_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>WalkWithBriefcase</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>978d4fdf3ff1126e</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040360000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>WalkWithBriefcase_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>978d4fdf3ff1126e</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\WalkWithBriefcase_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>DescendStairs</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>3126e9793ff2ac08</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040370000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>WalkDownStairs_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>3126e9793ff2ac08</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\WalkDownStairs_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>AscendStairs</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>0000000040000000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>645a1cac3ff5df3b</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040380000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>WalkUpStairs_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>645a1cac3ff5df3b</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\WalkUpStairs_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>Picking</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>cccccccd4018cccc</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>0000000040390000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>Picking_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>cccccccd4018cccc</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\Picking_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>Open</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>0000000040100000</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000403a0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>OpenCabinet_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>0000000040100000</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\OpenCloseCabinet_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>Close</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>0000000040140000</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000403a0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>CloseCabinet_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>0000000040000000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>0000000040140000</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\OpenCloseCabinet_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>TalkingOnPhone</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>c083126f401421ca</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000403b0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>TalkingOnPhone_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>c083126f401421ca</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\TalkingOnPhone_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>UseTablet</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>d2f1a9fc4027224d</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000403c0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>StandingUsingTouchscreen_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>d2f1a9fc4027224d</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\StandingUsingTouchscreen_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>FaxMachine</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>33333333402a3333</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000403d0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>SendingFax_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>33333333402a3333</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\SendingFax_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
    <node f="42" dt="1"><name>ShakeHands</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42"><name>keyframes</name>
      <node f="40"><name></name></node></node>
     <node f="42" dt="1"><name>repeattype</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>repeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timetype</name><data>000000003ff00000</data></node>
     <node f="42"><name>startstate</name></node>
     <node f="42" dt="1"><name>starttime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>timescale</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>currepeattype</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>currepeatvalue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastupdatetime</name><data>00000000bff00000</data></node>
     <node f="42" dt="1"><name>triggers</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>clips</name><data>d916872b401177ce</data>
      <node f="40"><name></name></node>
      <node f="42" dt="7"><name></name><data/>
       <node f="40"><name></name></node>
       <node f="42" dt="2"><name>animationName</name><data>mixamo.com</data></node>
       <node f="42" dt="1"><name>animationIndex</name><data>00000000403e0000</data></node>
       <node f="42" dt="2"><name>clipName</name><data>ShakingHands_Both</data></node>
       <node f="42" dt="1"><name>clipIndex</name><data>000000003ff00000</data></node>
       <node f="42" dt="3"><name>clip</name><data><coupling>null</coupling></data></node>
       <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name>endTime</name><data>d916872b401177ce</data></node>
       <node f="42" dt="2"><name>animationFileName</name><data>fs3d\People\Animations\ShakingHands_Both.fbx</data></node>
       <node f="42" dt="2"><name>sdt::attributetree</name><data>AnimationClipInfo</data>
        <node f="40"><name></name></node></node>
      </node>
     </node>
    </node>
   </node>
   <node f="42"><name></name></node>
  </node>
  <node f="42" dt="3"><name>shapedata</name><data><coupling>/Police 2&gt;visual/localshapedata/1</coupling></data></node>
  <node f="42"><name>localshapedata</name>
   <node f="40"><name></name></node>
   <node f="10000042"><name></name>
    <node f="40"><name></name></node>
    <node f="42" dt="7"><name>Body</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>textureName</name><data>fs3d\People\Textures\Skin\MaleScan2\MaleScan2.png</data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000040554000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Body</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>000000003ff00000</data></node>
     <node f="42" dt="2"><name>textureName</name><data>fs3d\People\Textures\Skin\MaleScan2\MaleScan2.png</data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000040554000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Hat_Male_Fit_A_Captain_Hat</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040000000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Shoes_Male_Fit_A_Firefighter_Boots</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040080000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Hat_Male_Fit_A_Tactical_Response</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040100000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Hat_Male_Fit_A_Police_Cap</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040140000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Hair_Male_Fit_A_Alpha_Short_Hair</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040180000</data></node>
     <node f="42" dt="2"><name>textureName</name><data>fs3d\People\Textures\Hair\Male_Short\Hair_MaleFitA_AlphaShortHair.png</data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>00000000401c0000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>5c5c5c5c3fdc5c5c</data></node>
       <node f="42" dt="1"><name></name><data>d8d8d8d93fd8d8d8</data></node>
       <node f="42" dt="1"><name></name><data>969696973fd69696</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Gloves_Male_Fit_A_Combat_Gloves</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>00000000401c0000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Shoes_Male_Fit_A_Boots</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040200000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Head_Male_Blue</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040220000</data></node>
     <node f="42" dt="2"><name>textureName</name><data>fs3d\People\Textures\Skin\MaleScan2\MaleScan2.png</data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000040554000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Hat_Male_Fit_A_Hard_Hat</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040240000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Shoes_Male_Fit_A_Short_Boot</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040260000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Bottom_Male_Fit_A_Police_Uniform</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040280000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Hat_Male_Fit_A_Baseball_Cap</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>00000000402a0000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Bottom_Male_Fit_A_Fire_Fighter_Pants</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>00000000402c0000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Hat_Male_Fit_A_Hat_And_Headphones</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>00000000402e0000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Bottom_Male_Fit_A_Tactical_Response</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040300000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Shoes_Male_Fit_A_Tactical_Boot_B</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040310000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Head_Male_Red</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040320000</data></node>
     <node f="42" dt="2"><name>textureName</name><data>fs3d\People\Textures\Skin\MaleScan2\MaleScan2.png</data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000040554000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Beard_And_Moustache</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040330000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Moustaches</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040340000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>0a3d70a43fd0a3d7</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Bottom_Male_Fit_A_Belted_Straight_Pant</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040350000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Top_Male_Fit_A_Tactical_Shirt</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040360000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Top_Male_Fit_A_Fire_Fighter_Jacket</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040370000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Beards</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040380000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>cccccccd3feccccc</data></node>
       <node f="42" dt="1"><name></name><data>cccccccd3feccccc</data></node>
       <node f="42" dt="1"><name></name><data>cccccccd3feccccc</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Top_Male_Fit_A_Tactical_Response</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040390000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Masks</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>00000000403a0000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Eyewear</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>00000000403b0000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Mask_Male_Fit_A_Surgical_Mask</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>00000000403c0000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Top_Male_Fit_A_Relaxed_V_NecK_Tee</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>00000000403d0000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>5c28f5c23fd5c28f</data></node>
       <node f="42" dt="1"><name></name><data>d70a3d713fdd70a3</data></node>
       <node f="42" dt="1"><name></name><data>5c28f5c23fe3c28f</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Glasses_Male_Fit_A_Classic_A</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>00000000403e0000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Top_Male_Fit_A_Long_Sleeve_Police_Uniform</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>00000000403f0000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Hat_Male_Fit_A_Fire_Fighter_Helmet</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040400000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Glasses_Male_Fit_A_Goggles_A</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040408000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
    <node f="42" dt="7"><name>Gloves_Male_Fit_A_Fingerless_Gloves</name><data/>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>hideMesh</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>meshIndex</name><data>0000000040410000</data></node>
     <node f="42" dt="2"><name>textureName</name><data></data></node>
     <node f="42" dt="1"><name>textureIndex</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectColor</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>useObjectTexture</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>hasTransparency</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>reflectivity</name><data>0000000000000000</data></node>
     <node f="42" dt="2"><name>sdt::attributetree</name><data>ShapeDataOverride</data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>diffuseColor</name><data></data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name></name><data>5c28f5c23fd5c28f</data></node>
       <node f="42" dt="1"><name></name><data>5c28f5c23fd5c28f</data></node>
       <node f="42" dt="1"><name></name><data>5c28f5c23fd5c28f</data></node>
       <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
      </node>
     </node>
    </node>
   </node>
  </node>
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
    <node f="42" dt="1"><name>curValue</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulative</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>cumulativeTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>minValue</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>maxValue</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>numEntries</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>lastSetTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>rate</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>lastResetTime</name><data>0000000000000000</data></node>
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
     <node f="210000042" dt="3"><name></name><data><coupling>/Police 2&gt;stats/HC_Availability_States/dependencies/_2</coupling></data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>sdt::attributetree</name><data>ComboStateChangeEvent</data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name>time</name><data>0000000000000000</data></node>
       <node f="42" dt="3"><name>involved</name><data><coupling>/Police 2&gt;stats/state_profiles/Availability/onChange</coupling></data></node>
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
     <entry><ed>ProvidingCare</ed><ed>0000000000000000</ed><ed>1</ed></entry></data></node>
    <node f="210000042"><name>onChange</name>
     <node f="40"><name></name></node>
     <node f="210000042" dt="3"><name></name><data><coupling>/Police 2&gt;stats/HC_Availability_States/dependencies/_1</coupling></data>
      <node f="40"><name></name></node>
      <node f="42" dt="2"><name>sdt::attributetree</name><data>ComboStateChangeEvent</data>
       <node f="40"><name></name></node>
       <node f="42" dt="1"><name>time</name><data>0000000000000000</data></node>
       <node f="42" dt="3"><name>involved</name><data><coupling>/Police 2&gt;stats/state_profiles/HC States/onChange</coupling></data></node>
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
    <entry><ed>3</ed><ed>0000000000000000</ed><ed>0</ed></entry><varchar>other</varchar><varchar>1</varchar><varchar>Idle_Available</varchar><varchar>2</varchar><varchar>Idle_Acquired</varchar><varchar>3</varchar><varchar>ProvidingCare_Acquired</varchar><varchar>4</varchar><varchar>ProvidingCare_Available</varchar></data></node>
   <node f="42"><name>dependencies</name>
    <node f="40"><name></name></node>
    <node f="10000042" dt="3"><name>_1</name><data><coupling>/Police 2&gt;stats/state_profiles/HC States/onChange/1</coupling></data></node>
    <node f="10000042" dt="3"><name>_2</name><data><coupling>/Police 2&gt;stats/state_profiles/Availability/onChange/1</coupling></data></node>
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
  <node f="42" dt="1"><name>stats_creationtime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>stats_lastmovetime</name><data>0000000000000000</data></node>
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
  <node f="42" dt="1"><name>lastPickPlaceOffsetResult</name><data>0000000000000000</data></node>
 </node>
 <node f="42"><name>special</name>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>title</name><data>Staff</data></node>
  <node f="42" dt="2"><name>description</name><data></data></node>
  <node f="42" dt="2"><name>tooltip</name><data>People</data></node>
  <node f="42" dt="2"><name>guifocusclass</name><data>VIEW:/standardviews/modelingutilities/QuickerProperties</data></node>
 </node>
 <node f="42"><name>labels</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Owner</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="1"><name>Priority</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>Preemptable</name><data>0000000000000000</data></node>
  <node f="42"><name>TravelingWithPatient</name></node>
 </node>
 <node f="42"><name>objectinfo</name>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>Availability:  Available</name><data>Available</data></node>
  <node f="42" dt="2"><name>State:  Idle</name><data>Idle</data></node>
 </node>
 <node f="4000000042" dt="2"><name>windowtitle</name><data>Staff</data>
  <node f="40"><name></name></node></node>
 <node f="42"><name>spatial</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>spatialx</name><data>f6eb416e402f3386</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>00000000c0408000</data></node>
  <node f="42" dt="1"><name>spatialz</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialsx</name><data>a00000003fd99999</data></node>
  <node f="42" dt="1"><name>spatialsy</name><data>200000003fe28f5c</data></node>
  <node f="42" dt="1"><name>spatialsz</name><data>400000003ffc7ae1</data></node>
  <node f="42" dt="1"><name>spatialrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialry</name><data>0000000080000000</data></node>
  <node f="42" dt="1"><name>spatialrz</name><data>000000004060e000</data></node>
  <node f="42" dt="1"><name>offsetx</name><data>000000003fe00000</data></node>
  <node f="42" dt="1"><name>offsety</name><data>000000003fe00000</data></node>
  <node f="42" dt="1"><name>offsetz</name><data>40000000bf847ae1</data></node>
  <node f="42" dt="1"><name>offsetsx</name><data>600000003f91b717</data></node>
  <node f="42" dt="1"><name>offsetsy</name><data>a00000003f999999</data></node>
  <node f="42" dt="1"><name>offsetsz</name><data>800000003f76f006</data></node>
  <node f="42" dt="1"><name>offsetrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>offsetrz</name><data>0000000040568000</data></node>
  <node f="42" dt="1"><name>centroid</name><data>000000003ff00000</data></node>
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
 <node f="42"><name>stored</name>
  <node f="40"><name></name></node>
  <node f="800000042" dt="2"><name>PeopleFlow</name><data>/Tools/People/Flows/InstancedFlows/Staff</data>
   <node f="40"><name></name></node>
   <node f="42"><name>blackBox</name>
    <node f="40"><name></name></node>
    <node f="42"><name>Idle Location</name>
     <node f="40"><name></name></node>
     <node f="442" dt="2"><name>value</name><data>Object current = param(1);
treenode activity = param(2);
Token token = param(3);
Variant assignTo = param(4);
string labelName = param(5);
treenode processFlow = ownerobject(activity);

/**Staff's Reset Position*/

Array resetLocation = current.resetPosition.location;
Array resetRotation = current.resetPosition.rotation;

return resetLocation.append(resetRotation);
</data></node>
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
      <node f="42" dt="2"><name></name><data>../../../../../../../../..&gt;variables/removeLabel</data></node>
     </node>
     <node f="42" dt="2"><name></name><data>/Tools/People/Flows/InstancedFlows/Staff&gt;variables/blackBox/Idle Location</data></node>
    </node>
   </node>
  </node>
 </node>
 <node f="42"><name>Groups</name>
  <node f="40"><name></name></node>
  <node f="810000042" dt="3"><name>_1</name><data><coupling>/Tools/Groups/Staff/_8</coupling></data>
   <node f="40"><name></name></node></node>
  <node f="810000042" dt="3"><name>_2</name><data><coupling>/Tools/Groups/Departure Police/_2</coupling></data></node>
 </node>
 <node f="42"><name>ActiveProcesses</name>
  <node f="40"><name></name></node></node>
</data></node></flexsim-tree>
