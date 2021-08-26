using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace NotasSesmestre
{
    public partial class Form1 : Form
    {   Funciones Objc = new Funciones();
        int fila = 0; bool band = false;
        public Form1()
        { InitializeComponent();
        }
        //Para poder usar la barra de panel como barra de herramientas
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //Poder arrastrar el panel y con él, el dtgrid
        private void PnBarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        { ReleaseCapture();
          SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void Form1_Load(object sender, EventArgs e)
        { int f=0, inicio, final; string tmp="";
          using (StreamReader Datos = new StreamReader("Datos.txt"))
          { while(!Datos.EndOfStream)
            { tmp = Datos.ReadLine();
              DgNotas.Rows.Add();
              inicio = 0;
              for(int c=0; c<4; c++)
              { final = Objc.BuscarCaracter(tmp, ';',inicio);
                DgNotas.Rows[f].Cells[c].Value = Objc.CopiarDesdeHasta(tmp, inicio, final-1);
                inicio = final + 1;
              }
              f++;
            }
          }
        }

        private void GuardarDatos()
        { int f=0; string tmp="";
          using (StreamWriter grabar = new StreamWriter("Datos.txt"))
          { while(f<DgNotas.RowCount)
            { tmp ="";
              for(int c=0; c<4; c++)
              { tmp += DgNotas.Rows[f].Cells[c].Value.ToString();
                if(c<4)
                  tmp += ";";
              }
              grabar.WriteLine(tmp);
              f++;
            }
          }
        }

        private void DgNotas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { int f= e.RowIndex;
          TxMateria.Text = DgNotas.Rows[f].Cells[0].Value.ToString();
          TxNota1.Text = DgNotas.Rows[f].Cells[1].Value.ToString();
          TxNota2.Text = DgNotas.Rows[f].Cells[2].Value.ToString();
          TxNota3.Text = DgNotas.Rows[f].Cells[3].Value.ToString();
          fila = f;
          band = true;          
        }

        private void TxboxaDgNotas(int f)
        { DgNotas.Rows[f].Cells[0].Value = TxMateria.Text;
          DgNotas.Rows[f].Cells[1].Value = TxNota1.Text;
          DgNotas.Rows[f].Cells[2].Value = TxNota2.Text;
          DgNotas.Rows[f].Cells[3].Value = TxNota3.Text;
        }

        private void Limpiar()
        { TxMateria.Text ="";
          TxNota1.Text = "";
          TxNota2.Text = "";
          TxNota3.Text = "";
        }

        private void BtAgregar_Click(object sender, EventArgs e)
        { int f=DgNotas.RowCount;
          if(TxMateria.Text !="")
          { DgNotas.Rows.Add();
            TxboxaDgNotas(f);
            Limpiar();
            GuardarDatos();
          }
          else
            MessageBox.Show("Debe llenar los datos primero que desea agregar");
        }

        private void BtGuardar_Click(object sender, EventArgs e)
        { if(band)
          { TxboxaDgNotas(fila);
            Limpiar();
            GuardarDatos();
            DgNotas.Rows[fila].Cells[4].Style.BackColor = Color.White;
            MessageBox.Show("Presione nuevamente el boton de promedio para actualizar las entradas");
          }
          else
            MessageBox.Show("Debe hacer doble-click sobre la fila donde va a modificar y guardar");
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        { if(band)
          { DgNotas.Rows.RemoveAt(fila);
            GuardarDatos();
            Limpiar();
          }
          else
            MessageBox.Show("Debe hacer doble-click sobre la fila que desea eliminar");
        }

        private void BtPromedio_Click(object sender, EventArgs e)
        { double n1, n2,n3, prom=0, min;
          for(int f=0; f<DgNotas.RowCount; f++)
          { if(DgNotas.Rows[f].Cells[1].Value.ToString() !="" && DgNotas.Rows[f].Cells[2].Value.ToString() !="" && DgNotas.Rows[f].Cells[3].Value.ToString() !="")
            { n1 = Convert.ToDouble(DgNotas.Rows[f].Cells[1].Value);
              n2 = Convert.ToDouble(DgNotas.Rows[f].Cells[2].Value);
              n3 = Convert.ToDouble(DgNotas.Rows[f].Cells[3].Value);
              prom = Objc.Acumulado(n1,n2,n3);
              if (prom < 3)
               DgNotas.Rows[f].Cells[4].Style.BackColor = Color.Orange;
              if (prom >=3)
               DgNotas.Rows[f].Cells[4].Style.BackColor = Color.LightGreen;
            }
            else
            { if(DgNotas.Rows[f].Cells[1].Value.ToString() !="" && DgNotas.Rows[f].Cells[2].Value.ToString() !="")
              { n1 = Convert.ToDouble(DgNotas.Rows[f].Cells[1].Value);
                n2 = Convert.ToDouble(DgNotas.Rows[f].Cells[2].Value);
                prom = Objc.Acumulado(n1,n2);
                min = (3.0 - prom) / 0.4;
                if(min>5)
                 DgNotas.Rows[f].Cells[4].Style.BackColor = Color.Orange;
                if(min>=4 && min <=5)
                 DgNotas.Rows[f].Cells[4].Style.BackColor = Color.LightBlue;
                if(min<=0)
                 DgNotas.Rows[f].Cells[4].Style.BackColor = Color.LightGreen;
              }
              else
              { if(DgNotas.Rows[f].Cells[1].Value.ToString() !="" || DgNotas.Rows[f].Cells[2].Value.ToString() !="")
                { if(DgNotas.Rows[f].Cells[1].Value.ToString() !="")
                  { n1 = Convert.ToDouble(DgNotas.Rows[f].Cells[1].Value);
                    prom = Objc.Acumulado(n1);
                  }
                  else
                  { n2 = Convert.ToDouble(DgNotas.Rows[f].Cells[2].Value);
                    prom = Objc.Acumulado(n2);
                  }
                }
              }
            }
            DgNotas.Rows[f].Cells[4].Value = prom.ToString();
          }
        }

        private void BtSalir_Click(object sender, EventArgs e)
        { Close();
        }
    }
}