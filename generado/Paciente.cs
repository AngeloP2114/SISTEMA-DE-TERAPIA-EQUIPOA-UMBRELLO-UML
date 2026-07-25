using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;


/// <summary>
/// 
/// </summary>
public class Paciente : Usuario
{

  #region Attributes

  /// <summary>
  /// 
  /// </summary>
  private int id;


  /// <summary>
  /// 
  /// </summary>
  private int edad;


  /// <summary>
  /// 
  /// </summary>
  private string diagnostico;


  /// <summary>
  /// 
  /// </summary>
  private string telefono;



  #endregion


  #region Public methods

  /// <summary>
  /// 
  /// </summary>
  /// <param name="nuevoDiagnostico"></param>
  /// <returns></returns>
  public void actualizarDiagnostico(string nuevoDiagnostico)
  {
    throw new Exception("The method or operation is not implemented.");
  }

  /// <summary>
  /// 
  /// </summary>
  /// <returns>double</returns>
  public double consultarProgreso()
  {
    throw new Exception("The method or operation is not implemented.");
  }

  #endregion


}

