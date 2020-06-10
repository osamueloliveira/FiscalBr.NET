﻿using FiscalBr.Common;

namespace SpedBr.EfdContribuicoes
{
    public class BlocoP
    {
        public RegistroP001 RegP001 { get; set; }
        public RegistroP001 RegP990 { get; set; }

        public class RegistroP001 : RegistroBaseSped
        {
            public RegistroP001()
            {
                Reg = "P001";
            }

            [SpedCampos(2, "IND_MOV", "C", 1, 0, true)]
            public IndMovimento IndMov { get; set; }

        }

        public class RegistroP990 : RegistroBaseSped
        {
            public RegistroP990()
            {
                Reg = "P990";
            }

            [SpedCampos(3, "QTD_LIN_P", "N", int.MaxValue, 0, true)]
            public int QtdLinP { get; set; }
        }
    }
}
