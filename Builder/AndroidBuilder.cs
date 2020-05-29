using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class AndroidBuilder : ICelular
    {
        public Celular celular;


        public AndroidBuilder()
        {
            celular = new Celular();
        }

        Celular ICelular.Celular
        {
            get
            {
                return this.celular;
            }
        }

        public void Nome()
        {
            this.celular.Nome = "Android";
        }

        public void BuildBateria()
        {
            this.celular.bateria = "MAH_1500";
        }

        public void BuildCamera()
        {
            this.celular.camera = "15 MP";
        }

        public void BuildSistema()
        {
            this.celular.SisOp = "Android 8.1";
        }

        public void BuildTela()
        {
            this.celular.tela = "7 pol";
        }

      
    }
}
