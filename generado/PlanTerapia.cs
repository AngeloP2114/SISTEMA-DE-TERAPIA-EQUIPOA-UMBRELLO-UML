using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;


/// <summary>
/// 
/// </summary>
public class PlanTerapia
{

  #region Aggregations

  /// <summary>
  /// 
  /// (Array of Ejercicio)
  /// </summary>
  public ArrayList UnnamedRoleB_1
  {
    get
    {
      return m_UnnamedRoleB_1;
    }
    set
    {
      m_UnnamedRoleB_1 = value;
    }
  }
  private ArrayList m_UnnamedRoleB_1;


  #endregion

  #region Attributes

  /// <summary>
  /// 
  /// </summary>
  private int id;


  /// <summary>
  /// 
  /// </summary>
  private DateTime fecha_inicio;


  /// <summary>
  /// 
  /// </summary>
  private DateTime fecha_fin;


  /// <summary>
  /// 
  /// </summary>
  private string objetivo;


  /// <summary>
  /// 
  /// </summary>
  private string estado;


  /// <summary>
  /// 
  /// </summary>
  private SesionTerapia new_attribute;



  #endregion


  #region Public methods

  /// <summary>
  /// 
  /// </summary>
  /// <param name="ejercicio"></param>
  /// <returns></returns>
  public void agregarEjercicio(Ejercicio ejercicio)
  {
    throw new Exception("The method or operation is not implemented.");
  }

  /// <summary>
  /// 
  /// </summary>
  /// <param name="nuevoEstado"></param>
  /// <returns></returns>
  public void cambiarEstado(string nuevoEstado)
  {
    throw new Exception("The method or operation is not implemented.");
  }

  /// <summary>
  /// 
  /// </summary>
  /// <returns>int</returns>
  public int calcularDuraci_nDias()
  {
    throw new Exception("The method or operation is not implemented.");
  }

  #endregion


}

