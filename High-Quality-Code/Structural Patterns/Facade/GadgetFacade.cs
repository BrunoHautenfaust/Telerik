namespace Facade
{
    using System;
    using Functionalities;

    public class GadgetFacade
    {   
        // Must be instantiated here, otherwise would not be accessible in the methoods
        private Binoculars binoculars;
        private Flamethrower flamethrower;
        private Springs springs;

        public GadgetFacade()
        {
            this.binoculars = new Binoculars();
            this.flamethrower = new Flamethrower();
            this.springs = new Springs();
        }

        public void GetBinoculars()
        {
            this.binoculars.OpenHat();
            this.binoculars.PositionBinoculars();
            this.binoculars.Zoom();
        }

        public void GetFlamethrower()
        {
            this.flamethrower.OpenHat();
            this.flamethrower.ExtendLighter();
            this.flamethrower.Burn();
        }

        public void GetSprings()
        {
            this.springs.OpenHat();
            this.springs.PrepareSprings();
            this.springs.Jump();
        }
    }
}
