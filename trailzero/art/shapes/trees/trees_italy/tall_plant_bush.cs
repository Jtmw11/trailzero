
singleton TSShapeConstructor(Tall_plant_bushDae)
{
   baseShape = "./tall_plant_bush.dae";
};

function Tall_plant_bushDae::onLoad(%this)
{
   %this.addImposter("25", "8", "0", "0", "128", "1", "0");
}
