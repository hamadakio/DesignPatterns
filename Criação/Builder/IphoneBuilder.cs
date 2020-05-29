using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class IphoneBuilder : ICelular
    {
        Celular celular;

        public IphoneBuilder()
        {
            this.celular = new Celular();
        }

        public Celular Celular
        {
            get
            {
                return this.celular;
            }
        }

        public void Nome()
        {
            this.celular.Nome = "Iphone";
        }
        public void BuildBateria()
        {
            this.celular.bateria = "MAH_1000";
        }

        public void BuildCamera()
        {
            this.celular.camera = "8 MP";
        }

        public void BuildSistema()
        {
            this.celular.SisOp = "Ios 12";
        }

        public void BuildTela()
        {
            this.celular.bateria = "4.8 pol";
        }

        
    }
}
