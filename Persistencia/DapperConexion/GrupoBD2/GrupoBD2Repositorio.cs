using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;

namespace Persistencia.DapperConexion.GrupoBD2
{
      public class GrupoBD2Repositorio : IGrupoBD2
      {
            private readonly IFactoryConnection _factoryConnection;
            public GrupoBD2Repositorio(IFactoryConnection factoryConnection)
            {
                  _factoryConnection = factoryConnection;
            }
            public Task<int> ActualizaGrupoBD2(GrupoBD2Model parametros)
            {
                  throw new System.NotImplementedException();
            }

            public Task<int> EliminaGrupoBD2(string consulta)
            {
                  throw new System.NotImplementedException();
            }

            public async Task<int> NuevoGrupoBD2(GrupoBD2Model parametros)
            {
                  var storeProcedure = "usp_GrupoBD_Nuevo";
                  try
                  {
                        var connection = _factoryConnection.GetConnection();
                        var resultado = await connection.ExecuteAsync(
                              storeProcedure,
                              new
                              {
                                    Consulta = parametros.Consulta,
                                    ConsultaFSID = Guid.NewGuid(),
                                    DescripcionConsulta = parametros.DescripcionConsulta,
                                    TipoBD = parametros.TipoBD,
                                    VersionBD = parametros.VersionBD,
                                    Entorno = parametros.Entorno,
                                    UltimaModificacion = DateTime.Now,
                                    UltimoUsuario = parametros.UltimoUsuario
                              },
                              commandType: CommandType.StoredProcedure
                              );
                        _factoryConnection.CloseConnection();
                        return resultado;
                  }
                  catch (Exception e)
                  {
                        throw new Exception("No se ha podido instar el nuevo registro", e);
                  }                  
            }

            public async Task<IEnumerable<GrupoBD2Model>> ObtenerLista()
            {
                  IEnumerable<GrupoBD2Model> grupoDB2List = null;
                  var storeProcedure = "usp_Obtener_GrupoBD2";
                  try
                  {
                        var connection = _factoryConnection.GetConnection();
                        grupoDB2List = await connection.QueryAsync<GrupoBD2Model>(storeProcedure, null, commandType: CommandType.StoredProcedure);
                  }
                  catch (Exception e)
                  {
                        throw new Exception("Error durante la consulta de datos", e);
                  }
                  finally
                  {
                        _factoryConnection.CloseConnection();
                  }
                  return grupoDB2List;
            }

            public async Task<IEnumerable<GrupoBD2Model>> ObtenerListaSinDescripcionConsulta()
            {
                  IEnumerable<GrupoBD2Model> grupoDB2List = null;
                  var storeProcedure = "usp_Obtener_GrupoBD2_SinDescripcionConsulta";
                  try
                  {
                        var connection = _factoryConnection.GetConnection();
                        grupoDB2List = await connection.QueryAsync<GrupoBD2Model>(storeProcedure, null, commandType: CommandType.StoredProcedure);
                  }
                  catch (Exception e)
                  {
                        throw new Exception("Error durante la consulta de datos", e);
                  }
                  finally
                  {
                        _factoryConnection.CloseConnection();
                  }
                  return grupoDB2List;
            }

            public Task<GrupoBD2Model> ObtenerPorConsulta(string consulta)
            {
                  throw new NotImplementedException();
            }
      }
}