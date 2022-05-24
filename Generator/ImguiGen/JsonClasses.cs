using System;
using System.Collections.Generic;
using System.Text;

namespace ImguiGen
{
    public class Rootobject
    {
        public Imguizmo_Allowaxisflip[] ImGuizmo_AllowAxisFlip { get; set; }
        public Imguizmo_Beginframe[] ImGuizmo_BeginFrame { get; set; }
        public Imguizmo_Decomposematrixtocomponents[] ImGuizmo_DecomposeMatrixToComponents { get; set; }
        public Imguizmo_Drawcubes[] ImGuizmo_DrawCubes { get; set; }
        public Imguizmo_Drawgrid[] ImGuizmo_DrawGrid { get; set; }
        public Imguizmo_Enable[] ImGuizmo_Enable { get; set; }
        public Imguizmo_Isover[] ImGuizmo_IsOver { get; set; }
        public Imguizmo_Isusing[] ImGuizmo_IsUsing { get; set; }
        public Imguizmo_Manipulate[] ImGuizmo_Manipulate { get; set; }
        public Imguizmo_Recomposematrixfromcomponents[] ImGuizmo_RecomposeMatrixFromComponents { get; set; }
        public Imguizmo_Setdrawlist[] ImGuizmo_SetDrawlist { get; set; }
        public Imguizmo_Setgizmosizeclipspace[] ImGuizmo_SetGizmoSizeClipSpace { get; set; }
        public Imguizmo_Setid[] ImGuizmo_SetID { get; set; }
        public Imguizmo_Setimguicontext[] ImGuizmo_SetImGuiContext { get; set; }
        public Imguizmo_Setorthographic[] ImGuizmo_SetOrthographic { get; set; }
        public Imguizmo_Setrect[] ImGuizmo_SetRect { get; set; }
        public Imguizmo_Viewmanipulate[] ImGuizmo_ViewManipulate { get; set; }
    }

    public class Imguizmo_Allowaxisflip
    {
        public string args { get; set; }
        public Argst[] argsT { get; set; }
        public string argsoriginal { get; set; }
        public string call_args { get; set; }
        public string cimguiname { get; set; }
        public Defaults defaults { get; set; }
        public string funcname { get; set; }
        public string location { get; set; }
        public string _namespace { get; set; }
        public string ov_cimguiname { get; set; }
        public string ret { get; set; }
        public string signature { get; set; }
        public string stname { get; set; }
    }

    public class Defaults
    {
    }

    public class Argst
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Imguizmo_Beginframe
    {
        public string args { get; set; }
        public object[] argsT { get; set; }
        public string argsoriginal { get; set; }
        public string call_args { get; set; }
        public string cimguiname { get; set; }
        public Defaults1 defaults { get; set; }
        public string funcname { get; set; }
        public string location { get; set; }
        public string _namespace { get; set; }
        public string ov_cimguiname { get; set; }
        public string ret { get; set; }
        public string signature { get; set; }
        public string stname { get; set; }
    }

    public class Defaults1
    {
    }

    public class Imguizmo_Decomposematrixtocomponents
    {
        public string args { get; set; }
        public Argst1[] argsT { get; set; }
        public string argsoriginal { get; set; }
        public string call_args { get; set; }
        public string cimguiname { get; set; }
        public Defaults2 defaults { get; set; }
        public string funcname { get; set; }
        public string location { get; set; }
        public string _namespace { get; set; }
        public string ov_cimguiname { get; set; }
        public string ret { get; set; }
        public string signature { get; set; }
        public string stname { get; set; }
    }

    public class Defaults2
    {
    }

    public class Argst1
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Imguizmo_Drawcubes
    {
        public string args { get; set; }
        public Argst2[] argsT { get; set; }
        public string argsoriginal { get; set; }
        public string call_args { get; set; }
        public string cimguiname { get; set; }
        public Defaults3 defaults { get; set; }
        public string funcname { get; set; }
        public string location { get; set; }
        public string _namespace { get; set; }
        public string ov_cimguiname { get; set; }
        public string ret { get; set; }
        public string signature { get; set; }
        public string stname { get; set; }
    }

    public class Defaults3
    {
    }

    public class Argst2
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Imguizmo_Drawgrid
    {
        public string args { get; set; }
        public Argst3[] argsT { get; set; }
        public string argsoriginal { get; set; }
        public string call_args { get; set; }
        public string cimguiname { get; set; }
        public Defaults4 defaults { get; set; }
        public string funcname { get; set; }
        public string location { get; set; }
        public string _namespace { get; set; }
        public string ov_cimguiname { get; set; }
        public string ret { get; set; }
        public string signature { get; set; }
        public string stname { get; set; }
    }

    public class Defaults4
    {
    }

    public class Argst3
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Imguizmo_Enable
    {
        public string args { get; set; }
        public Argst4[] argsT { get; set; }
        public string argsoriginal { get; set; }
        public string call_args { get; set; }
        public string cimguiname { get; set; }
        public Defaults5 defaults { get; set; }
        public string funcname { get; set; }
        public string location { get; set; }
        public string _namespace { get; set; }
        public string ov_cimguiname { get; set; }
        public string ret { get; set; }
        public string signature { get; set; }
        public string stname { get; set; }
    }

    public class Defaults5
    {
    }

    public class Argst4
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Imguizmo_Isover
    {
        public string args { get; set; }
        public Argst5[] argsT { get; set; }
        public string argsoriginal { get; set; }
        public string call_args { get; set; }
        public string cimguiname { get; set; }
        public Defaults6 defaults { get; set; }
        public string funcname { get; set; }
        public string location { get; set; }
        public string _namespace { get; set; }
        public string ov_cimguiname { get; set; }
        public string ret { get; set; }
        public string signature { get; set; }
        public string stname { get; set; }
    }

    public class Defaults6
    {
    }

    public class Argst5
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Imguizmo_Isusing
    {
        public string args { get; set; }
        public object[] argsT { get; set; }
        public string argsoriginal { get; set; }
        public string call_args { get; set; }
        public string cimguiname { get; set; }
        public Defaults7 defaults { get; set; }
        public string funcname { get; set; }
        public string location { get; set; }
        public string _namespace { get; set; }
        public string ov_cimguiname { get; set; }
        public string ret { get; set; }
        public string signature { get; set; }
        public string stname { get; set; }
    }

    public class Defaults7
    {
    }

    public class Imguizmo_Manipulate
    {
        public string args { get; set; }
        public Argst6[] argsT { get; set; }
        public string argsoriginal { get; set; }
        public string call_args { get; set; }
        public string cimguiname { get; set; }
        public Defaults8 defaults { get; set; }
        public string funcname { get; set; }
        public string location { get; set; }
        public string _namespace { get; set; }
        public string ov_cimguiname { get; set; }
        public string ret { get; set; }
        public string signature { get; set; }
        public string stname { get; set; }
    }

    public class Defaults8
    {
        public string boundsSnap { get; set; }
        public string deltaMatrix { get; set; }
        public string localBounds { get; set; }
        public string snap { get; set; }
    }

    public class Argst6
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Imguizmo_Recomposematrixfromcomponents
    {
        public string args { get; set; }
        public Argst7[] argsT { get; set; }
        public string argsoriginal { get; set; }
        public string call_args { get; set; }
        public string cimguiname { get; set; }
        public Defaults9 defaults { get; set; }
        public string funcname { get; set; }
        public string location { get; set; }
        public string _namespace { get; set; }
        public string ov_cimguiname { get; set; }
        public string ret { get; set; }
        public string signature { get; set; }
        public string stname { get; set; }
    }

    public class Defaults9
    {
    }

    public class Argst7
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Imguizmo_Setdrawlist
    {
        public string args { get; set; }
        public Argst8[] argsT { get; set; }
        public string argsoriginal { get; set; }
        public string call_args { get; set; }
        public string cimguiname { get; set; }
        public Defaults10 defaults { get; set; }
        public string funcname { get; set; }
        public string location { get; set; }
        public string _namespace { get; set; }
        public string ov_cimguiname { get; set; }
        public string ret { get; set; }
        public string signature { get; set; }
        public string stname { get; set; }
    }

    public class Defaults10
    {
        public string drawlist { get; set; }
    }

    public class Argst8
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Imguizmo_Setgizmosizeclipspace
    {
        public string args { get; set; }
        public Argst9[] argsT { get; set; }
        public string argsoriginal { get; set; }
        public string call_args { get; set; }
        public string cimguiname { get; set; }
        public Defaults11 defaults { get; set; }
        public string funcname { get; set; }
        public string location { get; set; }
        public string _namespace { get; set; }
        public string ov_cimguiname { get; set; }
        public string ret { get; set; }
        public string signature { get; set; }
        public string stname { get; set; }
    }

    public class Defaults11
    {
    }

    public class Argst9
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Imguizmo_Setid
    {
        public string args { get; set; }
        public Argst10[] argsT { get; set; }
        public string argsoriginal { get; set; }
        public string call_args { get; set; }
        public string cimguiname { get; set; }
        public Defaults12 defaults { get; set; }
        public string funcname { get; set; }
        public string location { get; set; }
        public string _namespace { get; set; }
        public string ov_cimguiname { get; set; }
        public string ret { get; set; }
        public string signature { get; set; }
        public string stname { get; set; }
    }

    public class Defaults12
    {
    }

    public class Argst10
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Imguizmo_Setimguicontext
    {
        public string args { get; set; }
        public Argst11[] argsT { get; set; }
        public string argsoriginal { get; set; }
        public string call_args { get; set; }
        public string cimguiname { get; set; }
        public Defaults13 defaults { get; set; }
        public string funcname { get; set; }
        public string location { get; set; }
        public string _namespace { get; set; }
        public string ov_cimguiname { get; set; }
        public string ret { get; set; }
        public string signature { get; set; }
        public string stname { get; set; }
    }

    public class Defaults13
    {
    }

    public class Argst11
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Imguizmo_Setorthographic
    {
        public string args { get; set; }
        public Argst12[] argsT { get; set; }
        public string argsoriginal { get; set; }
        public string call_args { get; set; }
        public string cimguiname { get; set; }
        public Defaults14 defaults { get; set; }
        public string funcname { get; set; }
        public string location { get; set; }
        public string _namespace { get; set; }
        public string ov_cimguiname { get; set; }
        public string ret { get; set; }
        public string signature { get; set; }
        public string stname { get; set; }
    }

    public class Defaults14
    {
    }

    public class Argst12
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Imguizmo_Setrect
    {
        public string args { get; set; }
        public Argst13[] argsT { get; set; }
        public string argsoriginal { get; set; }
        public string call_args { get; set; }
        public string cimguiname { get; set; }
        public Defaults15 defaults { get; set; }
        public string funcname { get; set; }
        public string location { get; set; }
        public string _namespace { get; set; }
        public string ov_cimguiname { get; set; }
        public string ret { get; set; }
        public string signature { get; set; }
        public string stname { get; set; }
    }

    public class Defaults15
    {
    }

    public class Argst13
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Imguizmo_Viewmanipulate
    {
        public string args { get; set; }
        public Argst14[] argsT { get; set; }
        public string argsoriginal { get; set; }
        public string call_args { get; set; }
        public string cimguiname { get; set; }
        public Defaults16 defaults { get; set; }
        public string funcname { get; set; }
        public string location { get; set; }
        public string _namespace { get; set; }
        public string ov_cimguiname { get; set; }
        public string ret { get; set; }
        public string signature { get; set; }
        public string stname { get; set; }
    }

    public class Defaults16
    {
    }

    public class Argst14
    {
        public string name { get; set; }
        public string type { get; set; }
    }

}
