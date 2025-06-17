using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.EditorInput;

namespace SurfaceCorrectionPlugin
{
    public class Commands
    {
        [CommandMethod("CorrectContours")]
        public void CorrectContours()
        {
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
            ed.WriteMessage("\nКоманда CorrectContours вызвана. Пока что это заглушка.");
        }
    }
}