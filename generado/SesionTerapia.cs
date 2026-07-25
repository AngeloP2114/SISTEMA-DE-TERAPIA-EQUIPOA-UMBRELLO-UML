using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;


/// <summary>
/// 
/// </summary>
public class SesionTerapia
{

  #region Attributes

  /// <summary>
  /// 
  /// </summary>
  private int id;


  /// <summary>
  /// 
  /// </summary>
  private DateTime fecha;


  /// <summary>
  /// 
  /// </summary>
  private int duracion_Minutos;


  /// <summary>
  /// 
  /// </summary>
  private string observaciones;


  /// <summary>
  /// 
  /// </summary>
  private bool Estado_completo;


  /// <summary>
  /// 
  /// </summary>
  private EvaluacionProgreso new_attribute;



  #endregion


  #region Public methods

  /// <summary>
  /// 
  /// </summary>
  /// <returns></returns>
  public void finalizarSesion()
  {
    throw new Exception("The method or operation is not implemented.");
  }

  /// <summary>
  /// 
  /// </summary>
  /// <param name="sesionesRealizadas"></param>
  /// <param name="sesionesPlanificadas"></param>
  /// <returns>double</returns>
  public double calcularProgreso(int sesionesRealizadas, int sesionesPlanificadas)
  {
    throw new Exception("The method or operation is not implemented.");
  }

  #endregion


}

