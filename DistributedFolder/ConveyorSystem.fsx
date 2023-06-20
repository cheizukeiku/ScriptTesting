<?xml version="1.0" encoding="UTF-8"?>
<flexsim-tree version="4" treetype="distributed">
<node f="20072" dt="4"><name>ConveyorSystem</name><data>
 <node f="40"><name></name></node>
 <node f="42"><name>classes</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>Conveyor::ConveyorSystem</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>superclasses</name>
  <node f="40"><name></name></node>
  <node f="42" dt="3"><name>FlexSimEventHandler</name><data><coupling>null</coupling></data></node>
 </node>
 <node f="42"><name>variables</name>
  <node f="40"><name></name></node>
  <node f="42"><name>conveyors</name>
   <node f="40"><name></name></node>
   <node f="42" dt="3"><name>_1</name><data><coupling>/StraightConveyor1&gt;variables/system/1</coupling></data></node>
   <node f="42" dt="3"><name>_2</name><data><coupling>/StraightConveyor2&gt;variables/system/1</coupling></data></node>
   <node f="42" dt="3"><name>_3</name><data><coupling>/StraightConveyor3&gt;variables/system/1</coupling></data></node>
   <node f="42" dt="3"><name>_4</name><data><coupling>/StraightConveyor4&gt;variables/system/1</coupling></data></node>
   <node f="42" dt="3"><name>_5</name><data><coupling>/CurvedConveyor1&gt;variables/system/1</coupling></data></node>
  </node>
  <node f="42"><name>conveyorPoints</name>
   <node f="40"><name></name></node>
   <node f="42" dt="3"><name>_1</name><data><coupling>/StraightConveyor1&gt;variables/conveyorPoints/_1/system</coupling></data></node>
   <node f="42" dt="3"><name>_2</name><data><coupling>/StraightConveyor4&gt;variables/conveyorPoints/_3/system</coupling></data></node>
   <node f="42" dt="3"><name>_3</name><data><coupling>/StraightConveyor2&gt;variables/conveyorPoints/_1/system</coupling></data></node>
   <node f="42" dt="3"><name>_4</name><data><coupling>/StraightConveyor3&gt;variables/conveyorPoints/_1/system</coupling></data></node>
   <node f="42" dt="3"><name>_5</name><data><coupling>/StraightConveyor1&gt;variables/conveyorPoints/_2/system</coupling></data></node>
   <node f="42" dt="3"><name>_6</name><data><coupling>/CurvedConveyor1&gt;variables/conveyorPoints/_2/system</coupling></data></node>
   <node f="42" dt="3"><name>_7</name><data><coupling>/StraightConveyor2&gt;variables/conveyorPoints/_2/system</coupling></data></node>
   <node f="42" dt="3"><name>_8</name><data><coupling>/StraightConveyor4&gt;variables/conveyorPoints/_1/system</coupling></data></node>
   <node f="42" dt="3"><name>_9</name><data><coupling>/StraightConveyor3&gt;variables/conveyorPoints/_2/system</coupling></data></node>
   <node f="42" dt="3"><name>_10</name><data><coupling>/StraightConveyor4&gt;variables/conveyorPoints/_2/system</coupling></data></node>
   <node f="42" dt="3"><name>_11</name><data><coupling>/StraightConveyor1&gt;variables/conveyorPoints/_3/system</coupling></data></node>
   <node f="42" dt="3"><name>_12</name><data><coupling>/CurvedConveyor1&gt;variables/conveyorPoints/_1/system</coupling></data></node>
  </node>
  <node f="42"><name>items</name></node>
  <node f="42"><name>decisionPoints</name></node>
  <node f="42"><name>photoEyes</name></node>
  <node f="42"><name>visualizations</name>
   <node f="40"><name></name></node>
   <node f="2000000042" dt="7"><name>RollerConveyor</name><data/>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>drawRollers</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>rollerDiameter</name><data>47ae147b3fb47ae1</data></node>
    <node f="42" dt="1"><name>rollerSpacing</name><data>c28f5c293fbc28f5</data></node>
    <node f="42" dt="1"><name>drawBelt</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>beltRepeatDist</name><data>0000000040140000</data></node>
    <node f="42" dt="2"><name>beltTexture</name><data>modules\Conveyor\shapes\Belt1.png</data></node>
    <node f="42" dt="1"><name>beltColor</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
    </node>
    <node f="42" dt="1"><name>legHeight</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>legHeightBasis</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>legRepeatDist</name><data>0000000040140000</data></node>
    <node f="42" dt="1"><name>legBase</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>sideSkirtWidth</name><data>47ae147b3f947ae1</data></node>
    <node f="42" dt="1"><name>sideSkirtHeight</name><data>333333333fc33333</data></node>
    <node f="42" dt="1"><name>sideSkirtZCenter</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>sideSkirtRepeatDist</name><data>000000003fe00000</data></node>
    <node f="42" dt="2"><name>sideSkirtTexture</name><data>modules\Conveyor\shapes\BasicSideSkirt.png</data></node>
    <node f="42" dt="1"><name>drawSideSkirtTexture</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>drawColor</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
    </node>
    <node f="42" dt="1"><name>rollerColor</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>beltYRepeatMode</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>beltYRepeatValue</name><data>0000000040140000</data></node>
   </node>
   <node f="2000000042" dt="7"><name>BeltConveyor</name><data/>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>drawRollers</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>rollerDiameter</name><data>47ae147b3fb47ae1</data></node>
    <node f="42" dt="1"><name>rollerSpacing</name><data>c28f5c293fbc28f5</data></node>
    <node f="42" dt="1"><name>drawBelt</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>beltRepeatDist</name><data>0000000040140000</data></node>
    <node f="42" dt="1"><name>beltColor</name><data>0000000000000000</data></node>
    <node f="42" dt="2"><name>beltTexture</name><data>modules\Conveyor\shapes\Belt1.png</data></node>
    <node f="42" dt="1"><name>legHeight</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>legHeightBasis</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>legRepeatDist</name><data>0000000040140000</data></node>
    <node f="42" dt="1"><name>legBase</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>sideSkirtWidth</name><data>47ae147b3f947ae1</data></node>
    <node f="42" dt="1"><name>sideSkirtHeight</name><data>333333333fc33333</data></node>
    <node f="42" dt="1"><name>sideSkirtZCenter</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>sideSkirtRepeatDist</name><data>000000003fe00000</data></node>
    <node f="42" dt="2"><name>sideSkirtTexture</name><data>modules\Conveyor\shapes\BasicSideSkirt.png</data></node>
    <node f="42" dt="1"><name>drawSideSkirtTexture</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>drawColor</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>beltYRepeatMode</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>beltYRepeatValue</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>rollerColor</name><data>0000000000000000</data></node>
   </node>
   <node f="2000000042" dt="7"><name>MassFlowConveyor</name><data/>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>drawRollers</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>rollerDiameter</name><data>47ae147b3fb47ae1</data></node>
    <node f="42" dt="1"><name>rollerSpacing</name><data>c28f5c293fbc28f5</data></node>
    <node f="42" dt="1"><name>drawBelt</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>beltRepeatDist</name><data>000000003fe00000</data></node>
    <node f="42" dt="1"><name>beltYRepeatMode</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>beltYRepeatValue</name><data>9999999a3fd99999</data></node>
    <node f="42" dt="1"><name>beltColor</name><data>0000000000000000</data></node>
    <node f="42" dt="2"><name>beltTexture</name><data>modules\Conveyor\shapes\TileBelt.jpg</data></node>
    <node f="42" dt="1"><name>legHeight</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>legHeightBasis</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>legRepeatDist</name><data>0000000040140000</data></node>
    <node f="42" dt="1"><name>legBase</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>sideSkirtWidth</name><data>47ae147b3f947ae1</data></node>
    <node f="42" dt="1"><name>sideSkirtHeight</name><data>333333333fc33333</data></node>
    <node f="42" dt="1"><name>sideSkirtZCenter</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>sideSkirtRepeatDist</name><data>0000000040000000</data></node>
    <node f="42" dt="1"><name>drawSideSkirtTexture</name><data>000000003ff00000</data></node>
    <node f="42" dt="2"><name>sideSkirtTexture</name><data>modules\Conveyor\shapes\BasicSideSkirt.png</data></node>
    <node f="42" dt="1"><name>drawColor</name><data>0000000000000000</data>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
    </node>
    <node f="42" dt="1"><name>rollerColor</name><data>0000000000000000</data></node>
   </node>
  </node>
  <node f="42" dt="3"><name>defaultVisualization</name><data><coupling>/ConveyorSystem&gt;variables/visualizations/RollerConveyor</coupling></data></node>
  <node f="42" dt="3"><name>defaultMassFlowVisualization</name><data><coupling>/ConveyorSystem&gt;variables/visualizations/MassFlowConveyor</coupling></data></node>
  <node f="42"><name>transferTypes</name>
   <node f="40"><name></name></node>
   <node f="2000000042" dt="7"><name>TransferType1</name><data/>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>inlineTransferMaxAngle</name><data>00000000404e0000</data></node>
    <node f="42" dt="1"><name>inlineSpeedType</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>sideTransferMaxAngle</name><data>0000000040668000</data></node>
    <node f="42" dt="1"><name>sideSpeedType</name><data>0000000040080000</data></node>
    <node f="42" dt="1"><name>startTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>finishTime</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>transferTime</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>customSpeed</name><data>000000003ff00000</data></node>
    <node f="42" dt="1"><name>popupDist</name><data>0000000000000000</data></node>
    <node f="42" dt="1"><name>doSmoothTransitions</name><data>000000003ff00000</data></node>
   </node>
  </node>
  <node f="42" dt="3"><name>defaultTransferType</name><data><coupling>/ConveyorSystem&gt;variables/transferTypes/TransferType1</coupling></data></node>
  <node f="42"><name>entryTransferTypes</name></node>
  <node f="42" dt="3"><name>defaultEntryTransferType</name><data><coupling>null</coupling></data></node>
  <node f="4000000042" dt="2"><name>defaultConveyorGroup</name><data>Conveyors</data></node>
  <node f="4000000042" dt="2"><name>defaultEntryTransferGroup</name><data>EntryTransfers</data></node>
  <node f="4000000042" dt="2"><name>defaultExitTransferGroup</name><data>ExitTransfers</data></node>
  <node f="4000000042" dt="2"><name>defaultDecisionPointGroup</name><data>DecisionPoints</data></node>
  <node f="4000000042" dt="2"><name>defaultPhotoEyeGroup</name><data>PhotoEyes</data></node>
  <node f="4000000042" dt="2"><name>defaultStationGroup</name><data>Stations</data></node>
  <node f="4000000042" dt="2"><name>defaultMassFlowConveyorGroup</name><data>MassFlowConveyors</data></node>
  <node f="4000000042" dt="2"><name>defaultMassFlowEntryTransferGroup</name><data>MassFlowEntryTransfers</data></node>
  <node f="4000000042" dt="2"><name>defaultMassFlowExitTransferGroup</name><data>MassFlowExitTransfers</data></node>
  <node f="42"><name>exitTransferTypes</name></node>
  <node f="42" dt="3"><name>defaultExitTransferType</name><data><coupling>null</coupling></data></node>
  <node f="42" dt="1"><name>lastUpdateTime</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>showFixedIntervals</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>showDecisionPoints</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>showPhotoEyes</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>showTransfers</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>snapThreshold</name><data>9999999a3fc99999</data></node>
  <node f="42" dt="1"><name>dpDrawSize</name><data>9999999a3fd99999</data></node>
  <node f="42" dt="1"><name>renderMode</name><data>000000003ff00000</data></node>
  <node f="42"><name>recycleBins</name></node>
  <node f="42" dt="1"><name>showFlowLines</name><data>0000000000000000</data></node>
  <node f="42"><name>flowUnits</name></node>
  <node f="42"><name>peBlockedColor</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>000000003ff00000</data></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
  </node>
  <node f="42"><name>peBlockingColor</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>9999999a3fe99999</data></node>
   <node f="42" dt="1"><name></name><data>9999999a3fe99999</data></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
  </node>
  <node f="42"><name>peClearingColor</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>cccccccd3feccccc</data></node>
   <node f="42" dt="1"><name></name><data>000000003fe00000</data></node>
   <node f="42" dt="1"><name></name><data>0000000000000000</data></node>
  </node>
  <node f="42" dt="1"><name>stations</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>propogateNonAccumStops</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>doConveyorGroupTemplate</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>doEntryTransferGroupTemplate</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>doExitTransferGroupTemplate</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>doPhotoEyeGroupTemplate</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>doDecisionPointGroupTemplate</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>doStationGroupTemplate</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>doMassFlowConveyorGroupTemplate</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>doMassFlowEntryTransferGroupTemplate</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>doMassFlowExitTransferGroupTemplate</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>dragListeningList</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>showFlowUnits</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>meshData</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>mfcRandMaxLoops</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>mfcRandMaxDensityRatio</name><data>0000000000000000</data></node>
 </node>
 <node f="42"><name>behaviour</name>
  <node f="40"><name></name></node></node>
 <node f="42"><name>visual</name>
  <node f="40"><name></name></node>
  <node f="42"><name>color</name>
   <node f="40"><name>OnDraw</name></node>
   <node f="42" dt="1"><name>red</name><data>000000003ff00000</data></node>
   <node f="42" dt="1"><name>green</name><data>000000003ff00000</data></node>
   <node f="42" dt="1"><name>blue</name><data>000000003ff00000</data></node>
  </node>
  <node f="42" dt="2"><name>shape</name><data>***</data>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>modules\Conveyor\shapes\SilverRoller.ac</name><data>modules\Conveyor\shapes\SilverRoller.ac</data>
    <node f="40"><name></name></node>
    <node f="42" dt="7"><name>mesh</name><data/>
     <node f="40"><name></name></node></node>
   </node>
   <node f="42" dt="2"><name>modules\Conveyor\shapes\WhiteRoller.ac</name><data>modules\Conveyor\shapes\WhiteRoller.ac</data>
    <node f="40"><name></name></node>
    <node f="42" dt="7"><name>mesh</name><data/>
     <node f="40"><name></name></node></node>
   </node>
   <node f="42" dt="2"><name>modules\Conveyor\shapes\SideSkirt.ac</name><data>modules\Conveyor\shapes\SideSkirt.ac</data>
    <node f="40"><name></name></node>
    <node f="42" dt="7"><name>mesh</name><data/>
     <node f="40"><name></name></node></node>
   </node>
   <node f="42" dt="2"><name>modules\Conveyor\shapes\ConveyorLegTop.ac</name><data>modules\Conveyor\shapes\ConveyorLegTop.ac</data>
    <node f="40"><name></name></node>
    <node f="42" dt="7"><name>mesh</name><data/>
     <node f="40"><name></name></node></node>
   </node>
   <node f="42" dt="2"><name>modules\Conveyor\shapes\ConveyorLegTopHanging.ac</name><data>modules\Conveyor\shapes\ConveyorLegTopHanging.ac</data>
    <node f="40"><name></name></node>
    <node f="42" dt="7"><name>mesh</name><data/>
     <node f="40"><name></name></node></node>
   </node>
   <node f="42" dt="2"><name>modules\Conveyor\shapes\ConveyorLegBottom.ac</name><data>modules\Conveyor\shapes\ConveyorLegBottom.ac</data>
    <node f="40"><name></name></node>
    <node f="42" dt="7"><name>mesh</name><data/>
     <node f="40"><name></name></node></node>
   </node>
   <node f="42" dt="2"><name>modules\Conveyor\shapes\ConveyorLegMiddle.ac</name><data>modules\Conveyor\shapes\ConveyorLegMiddle.ac</data>
    <node f="40"><name></name></node>
    <node f="42" dt="7"><name>mesh</name><data/>
     <node f="40"><name></name></node></node>
   </node>
  </node>
  <node f="42" dt="1"><name>shapeindex</name><data>0000000000000000</data>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>0000000040350000</data></node>
   <node f="42" dt="1"><name></name><data>0000000040360000</data></node>
   <node f="42" dt="1"><name></name><data>0000000040370000</data></node>
   <node f="42" dt="1"><name></name><data>0000000040380000</data></node>
   <node f="42" dt="1"><name></name><data>0000000040390000</data></node>
   <node f="42" dt="1"><name></name><data>00000000403a0000</data></node>
   <node f="42" dt="1"><name></name><data>00000000403b0000</data></node>
  </node>
  <node f="42" dt="1"><name>nochildscale</name><data>000000003ff00000</data></node>
  <node f="42" dt="2"><name>imagebase</name><data>***</data></node>
  <node f="42" dt="1"><name>imageindexbase</name><data>0000000000000000</data></node>
  <node f="42" dt="2"><name>imageobject</name><data>***</data>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name></name><data>modules\Conveyor\shapes\Belt1.png</data></node>
   <node f="42" dt="2"><name></name><data>modules\Conveyor\shapes\ConveyorRoller.png</data></node>
   <node f="42" dt="2"><name></name><data>modules\Conveyor\shapes\SideSkirt.png</data></node>
   <node f="42" dt="2"><name></name><data>modules\Conveyor\shapes\ConveyorLeg.png</data></node>
   <node f="42" dt="2"><name></name><data>modules\Conveyor\shapes\TileBelt.jpg</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>repeatDist</name><data>000000003ff00000</data></node>
   </node>
   <node f="42" dt="2"><name></name><data>modules\Conveyor\shapes\BasicSideSkirt.png</data>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>repeatDist</name><data>cccccccd3ffccccc</data></node>
   </node>
  </node>
  <node f="42" dt="1"><name>imageindexobject</name><data>0000000000000000</data>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name></name><data>00000000404c0000</data></node>
   <node f="42" dt="1"><name></name><data>00000000404c8000</data></node>
   <node f="42" dt="1"><name></name><data>00000000404d0000</data></node>
   <node f="42" dt="1"><name></name><data>00000000404d8000</data></node>
   <node f="42" dt="1"><name></name><data>000000004053c000</data></node>
   <node f="42" dt="1"><name></name><data>0000000040540000</data></node>
  </node>
  <node f="42" dt="1"><name>ignoredraw</name><data>0000000000000000</data></node>
 </node>
 <node f="42"><name>spatial</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>spatialx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialy</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialz</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialsx</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>spatialsy</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>spatialsz</name><data>000000003ff00000</data></node>
  <node f="42" dt="1"><name>spatialrx</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialry</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>spatialrz</name><data>0000000000000000</data></node>
  <node f="42" dt="1"><name>centroid</name><data>000000003ff00000</data></node>
 </node>
 <node f="42"><name>special</name>
  <node f="40"><name></name></node>
  <node f="42" dt="2"><name>guifocusclass</name><data>VIEW:/modules/Conveyor/ConveyorSystemProperties</data></node>
 </node>
 <node f="42"><name>stats</name>
  <node f="40"><name></name></node>
  <node f="42" dt="1"><name>recycleBins</name><data>0000000000000000</data>
   <node f="40"><name></name></node>
   <node f="42"><name>TraversalPoint</name></node>
   <node f="42"><name>ClearPoint</name></node>
   <node f="42"><name>CoverPoint</name></node>
   <node f="42"><name>EntrySpaceClearPoint</name></node>
   <node f="42"><name>MoveSpaceClearPoint</name></node>
   <node f="42"><name>AccumStoppedMoveSpaceClearPoint</name></node>
   <node f="42"><name>SpeedDriverChangePoint</name></node>
   <node f="42"><name>InlineTransferCenterTraversalPoint</name></node>
   <node f="42"><name>ConveyorEndStopPoint</name></node>
   <node f="42"><name>FREntrySpaceClearPoint</name></node>
   <node f="42"><name>NonAccumSlugBuilderEntryFinishPoint</name></node>
   <node f="42"><name>SlugBuilderFirstEntryAtEndPoint</name></node>
   <node f="42"><name>FixedIntervalMovePoint</name></node>
  </node>
 </node>
 <node f="4000000042" dt="2"><name>windowtitle</name><data>FlexSimEventHandler</data>
  <node f="40"><name></name></node></node>
</data></node></flexsim-tree>
