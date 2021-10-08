using Domain.Entities.Empleados;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Procesosss
{
    public class SalaryCalculator
    {
        public decimal inssrate => 0.07M;
        private TarifaIR[] tarifaIRs = new TarifaIR[]
        {
            new TarifaIR(){Desde = 0.01M, Hasta=100000,ImpuestoBase = 0, PorcentajeAplicable = 0, SobreExceso = 0},
            new TarifaIR(){Desde = 100000.01M, Hasta = 200000,ImpuestoBase = 0, PorcentajeAplicable = 0.15M, SobreExceso = 100000},
            new TarifaIR(){Desde = 200000.01M, Hasta = 350000,ImpuestoBase = 15000, PorcentajeAplicable = 0.20M, SobreExceso = 200000},
            new TarifaIR(){Desde = 350000.01M, Hasta = 500000,ImpuestoBase = 45000, PorcentajeAplicable = 0.25M, SobreExceso = 350000},
            new TarifaIR(){Desde = 500000.01M, Hasta = 10000000,ImpuestoBase = 87500, PorcentajeAplicable = 0.30M, SobreExceso = 500000},
        };

        private decimal CalcularSalarioAnual(decimal salario)
        {
            return salario * 12;
        }
        private decimal CalcularInss(decimal salario)
        {
            return salario* inssrate;
        }
        private decimal CalcularIr(decimal annualSalary)
        {
            decimal ir = decimal.MinValue;
            foreach (TarifaIR tarifaIR in tarifaIRs)
            {
                if ((annualSalary - tarifaIR.Desde) * (tarifaIR.Hasta - annualSalary) >= 0)
                {
                    ir = ((((annualSalary - tarifaIR.SobreExceso) * tarifaIR.PorcentajeAplicable) + tarifaIR.ImpuestoBase) / 12);
                    break;
                }
            }

            return ir;
        }
        private decimal CalcularSalarioPorHora(decimal salrio)
        {
            return salrio / 160;
        }
        private decimal CalcularSalarioExtraPorHoras(float horasextras ,decimal salarioPorHora)
        {
            return (decimal)horasextras * salarioPorHora;
        }
        public decimal CalcularSalary(Empleado empleado)
        {
            decimal salary = decimal.MinValue;
            decimal inss = CalcularInss(empleado.Salario);
            decimal annualSalary = decimal.MinValue, ir = decimal.MinValue, partialSalary = decimal.MinValue;

            if (empleado is Docente)
            {
                annualSalary = CalcularSalarioAnual(empleado.Salario - inss);
                partialSalary = empleado.Salario;
            }
            else if (empleado is Administrativo)
            {
                partialSalary = (empleado.Salario + CalcularSalarioExtraPorHoras(((Administrativo)empleado).HorasExtras, CalcularSalarioPorHora(empleado.Salario)));
                annualSalary = CalcularSalarioAnual(partialSalary - inss);
            }

            ir = CalcularIr(annualSalary);
            salary = partialSalary - inss - ir;

            return salary;
        }
    }
}
