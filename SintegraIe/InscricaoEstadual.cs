namespace SintegraIe
{
    /// <summary>
    /// Represents a valid Inscrição Estadual number
    /// </summary>
    public class InscricaoEstadual
    {
        /// <summary>
        /// Checks if a string value is a valid Inscrição Estadual representation
        /// </summary>
        /// <param name="uf">state of the Inscrição Estadual string to be checked</param>
        /// <param name="inscricaoEstadual">a Inscrição Estadual string to be checked</param>
        /// <returns>true if Inscrição Estadual string is valid; false otherwise</returns>
        public static bool Validate(string uf, string inscricaoEstadual)
        {
            var isValid = false;

            if (string.IsNullOrWhiteSpace(uf))
            {
                return isValid;
            }

            if (string.IsNullOrWhiteSpace(inscricaoEstadual))
            {
                return isValid;
            }

            var result = InscricaoEstadualHelper.ConsisteInscricaoEstadual(inscricaoEstadual, uf);

            isValid = result == 0;

            return isValid;
        }
    }
}
