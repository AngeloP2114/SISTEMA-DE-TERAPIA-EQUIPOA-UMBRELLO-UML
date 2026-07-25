using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;


/// <summary>
/// 
/// </summary>
public class Fisioterapeuta : Usuario
{

  #region Attributes

  /// <summary>
  /// 
  /// </summary>
  private int id;


  /// <summary>
  /// 
  /// </summary>
  private string especialidad;


  /// <summary>
  /// 
  /// </summary>
  private string numero_licencia;



  #endregion


  #region Public methods

  /// <summary>
  /// 
  /// </summary>
  /// <param name="paciente"></param>
  /// <returns></returns>
  public void EvaluarPaciente(Paciente paciente)
  {
    throw new Exception("The method or operation is not implemented.");
  }

  /// <summary>
  /// 
  /// </summary>
  /// <param name="paciente"></param>
  /// <returns></returns>
  public void crearPlanTerapia(Paciente paciente)
  {
    throw new Exception("The method or operation is not implemented.");
  }

  #endregion


}

