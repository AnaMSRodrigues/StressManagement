// BioData.cs
//
// margaridarodrigues
// a26418@alunos.ipca.pt
// 27/10/2023
namespace StressData;

public class BioData
{
    #region Atributes

    private int fc;
    private int fr;

    #endregion

    #region Constructor
    /// <summary>
    /// Constructor by default
    /// </summary>
    BioData()
    {
        fc = 60;
        fr = 16;
    }
    /// <summary>
    /// Constructor by values 
    /// </summary>
    /// <param name="c">HeartRate</param>
    /// <param name="r">RespiratoryFrequency</param>
    BioData(int c, int r)
    {
        fc = c;
        fr = r;
    }
    #endregion

    #region Proprerties
    /// <summary>
    /// Propertie for the atribute HeartRate
    /// </summary>
    int Fc
    {
        set
        {
            fc = value;
        }
        get
        {
            return fc;
        }
    }
    /// <summary>
    /// Propertie for the atribute Respiratory Frequency
    /// </summary>
    int Fr
    {
        set
        {
            fr = value;
        }
        get
        {
            return fr;
        }
    }
    #endregion

    #region Destructor
    /// <summary>
    /// Destructor by default
    /// </summary>
    ~BioData()
    {

    }


    #endregion
}

