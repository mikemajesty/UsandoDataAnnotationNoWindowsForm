é﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationInWidowsForm
{
    public class Pedido
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime DataPedido { get; set; }
        [DisplayName("User Name")]
        public string Username { get; set; }
        [Required(ErrorMessage = "{0} é obrigatório")]
        [StringLength(maximumLength: 50, MinimumLength = 3,ErrorMessage ="{0} deve contem de 3 até 50 letras")]
        public string Nome { get; set; }
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "{0} deve contem de 3 até 50 letras")]
        [Required(ErrorMessage = "{0} é obrigatório")]
        public string Sobrenome { get; set; }
        public string Enrereço { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CodigoPostal { get; set; }
        public string País { get; set; }
        public string Telefone { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }
        public decimal Total { get; set; }
    }
}
