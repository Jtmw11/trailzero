
singleton TSShapeConstructor(Cliff01Dae)
{
   baseShape = "./Cliff01.dae";
};

function Cliff01Dae::onLoad(%this)
{
   %this.setDetailLevelSize("800", "3000");
   %this.setDetailLevelSize("500", "2000");
}
