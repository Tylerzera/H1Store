﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.ViewModels
{
	public class FornecedorViewModel
	{
		public int Codigo { get; set; }
		public string RazaoSocial { get; set; }
		public string CNPJ { get; set; }
		public bool Ativo { get; set; }
		public DateTime DataCadastro { get; set; }
		public string EmailContato { get; set; }
	}
}
