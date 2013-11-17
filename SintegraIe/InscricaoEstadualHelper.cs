namespace SintegraIe
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// Helper class for PInvoke
    /// </summary>
    internal class InscricaoEstadualHelper
    {
        /// <summary>
        /// Checks if a string value is a valid Inscrição Estadual representation
        /// </summary>
        /// <param name="uf">state of the Inscrição Estadual string to be checked</param>
        /// <param name="inscricaoEstadual">a Inscrição Estadual string to be checked</param>
        /// <returns>true if Inscrição Estadual string is valid; false otherwise</returns>
        [DllImport("DllInscE32.dll", EntryPoint = "ConsisteInscricaoEstadual")]
        public static extern int ConsisteInscricaoEstadual(string uf, string inscricaoEstadual);
    }
}
