
singleton TSShapeConstructor(Holm_oak_filler_2Dae)
{
   baseShape = "./holm_oak_filler_2.dae";
};

function Holm_oak_filler_2Dae::onLoad(%this)
{
   %this.addImposter("25", "4", "0", "0", "256", "1", "0");
}
