using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_to_Class
{
    class Consts
    {
        public const string classIntro = "using System;\nusing System.Collections.Generic;\nusing System.Linq;\nusing System.Text;\nusing System.Threading.Tasks;\n\nnamespace CHANGE_WITH_NAMESPACE_NAME\n{\nclass ";
        public const string classSecondIntro = "\n{\n#region Defines\n";
        public const string classOutro = "#endregion\n}\n}";
        public const string space = " ";
        public const string accessModifiersPublic = "public";
        public const string accessModifiersPrivate = "private";
        public const string getterSetter = "{ get; set; }";
}
}
