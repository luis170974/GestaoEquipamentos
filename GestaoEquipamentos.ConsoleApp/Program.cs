using System;

namespace GestaoEquipamentos.ConsoleApp
{
    internal class Program
    {

        #region Metodos em static
        static int tamanhoArray = 1000;
        static string opcao;
        static int idChamado = 0;
        static int idEquipamento = 0;
        static int idSolicitante = 0;
        static DateTime dataDiasAbertos = new DateTime();

        static string[] nomeEquipamentos = new string[tamanhoArray];
        static double[] precoEquipamentos = new double[tamanhoArray];
        static string[] numeroSerieEquipamentos = new string[tamanhoArray];
        static string[] dataFabricacao = new string[tamanhoArray];
        static string[] fabricanteEquipamento = new string[tamanhoArray];
        static string[] tituloChamado = new string[tamanhoArray];
        static string[] descricaoChamado = new string[tamanhoArray];
        static string[] equipamentoChamado = new string[tamanhoArray];
        static string[] dataAberturaChamado = new string[tamanhoArray];
        static string[] diasAbertosChamado = new string[tamanhoArray];
        static string[] nomeSolicitante = new string[tamanhoArray];
        static string[] emailSolicitante = new string[tamanhoArray];
        static string[] numeroTelefoneSolicitante = new string[tamanhoArray];

        #endregion

        #region Metodos Auxiliares
        static string[] nomeEquipamentosAuxiliar = new string[tamanhoArray];
        static double[] precoEquipamentosAuxiliar = new double[tamanhoArray];
        static string[] numeroSerieEquipamentosAuxiliar = new string[tamanhoArray];
        static string[] dataFabricacaoAuxilar = new string[tamanhoArray];
        static string[] fabricanteEquipamentoAuxiliar = new string[tamanhoArray];
        static string[] tituloChamadoAuxiliar = new string[tamanhoArray];
        static string[] descricaoChamadoAuxiliar = new string[tamanhoArray];
        static string[] equipamentoChamadoAuxiliar = new string[tamanhoArray];
        static string[] dataAberturaChamadoAuxiliar = new string[tamanhoArray];
        static string[] diasAbertosChamadoAuxiliar = new string[tamanhoArray];
        #endregion

        static void Main(string[] args)
        {


            while (true)
            {

                #region Mostrar menu com opções
                MostrarMenu();
                #endregion

                #region registrar equipamento
                if (opcao == "1")
                {

                    RegistrarEquipamento();


                    Console.ReadKey();

                    Console.Clear();
                }
                #endregion

                #region editar equipamento
                if (opcao == "2")
                {
                    VisualizarHistorico();

                    EditarEquipamento();



                    Console.ReadKey();
                    Console.Clear();

                }
                #endregion

                #region excluir equipamento
                if (opcao == "3")
                {
                    VisualizarHistorico();

                    ExcluirEquipamento();

                    VisualizarHistorico();



                    Console.ReadKey();
                    Console.Clear();

                }

                #endregion

                #region historico de equipamentos
                if (opcao == "4")
                {
                    VisualizarHistorico();
                    Console.ReadKey();
                    Console.Clear();

                }
                #endregion

                #region registrar solicitante

                if (opcao == "5")
                {
                    RegistrarSolicitante();

                    Console.ReadLine();
                    Console.Clear();
                }

                    #endregion

                #region editar solicitante
                    if (opcao == "6")
                    {
                        EditarSolicitante();

                        Console.ReadLine();

                        Console.Clear();
                    }

                    #endregion

                #region excluir solicitante

                    if (opcao == "7")

                        ExcluirSolicitante();

                    Console.ReadLine();

                    Console.Clear();


                    #endregion

                #region historico solicitante
                    if (opcao == "8")
                    {
                        HistoricoSolicitante();

                        Console.ReadLine();

                        Console.Clear();
                    }
                    #endregion

                #region abrir chamado
                    if (opcao == "9")
                    {
                        AbrirChamados();

                        Console.ReadLine();

                        Console.Clear();
                    }

                    #endregion

                #region editar um chamado
                    if (opcao == "10")
                    {

                        VisualizarHistorico();

                        EditarChamados();

                        VisualizarHistorico();

                        Console.ReadLine();

                        Console.Clear();
                    }

                    #endregion

                #region excluir chamado
                    if (opcao == "11")
                    {
                        DeletarChamados();

                        Console.ReadKey();

                        Console.Clear();

                    }

                    #endregion

                #region histórico de chamados
                    if (opcao == "12")
                    {
                        HistoricoChamado();

                        Console.ReadLine();

                        Console.Clear();
                    }
                    #endregion

                #region sair
                    if (opcao == "s")
                    {
                        Console.WriteLine("Finalizando sistema!");
                        break;
                    }
                    #endregion

                

            }

            



        }

            


            static void MostrarMenu()
            {
                Console.WriteLine("### Menu Gestao de Equipamentos ###");
                Console.WriteLine("");

                Console.WriteLine("### Controle de Equipamentos ###");
                Console.WriteLine("");

                Console.WriteLine("1. Para registrar um novo equipamento ");

                Console.WriteLine("2. Para editar um equipamento existente ");

                Console.WriteLine("3. Excluir um equipamento ");

                Console.WriteLine("4. Historico de Equipamentos");

                Console.WriteLine("5. Registrar solicitante");

                Console.WriteLine("6. Editar solicitante");

                Console.WriteLine("7. Excluir solicitante");

                Console.WriteLine("8. Historico solicitantes");

                Console.WriteLine("");
                Console.WriteLine("### Controle Chamados ###");
                Console.WriteLine("");

                Console.WriteLine("9. Abrir um chamado ");

                Console.WriteLine("10. Para editar um chamado existente ");

                Console.WriteLine("11. Excluir um chamado ");

                Console.WriteLine("12. Historico de chamados ");

                Console.WriteLine("s. Para sair ");

                opcao = Console.ReadLine();
            }

            static void AbrirChamados()
            {
                for (int i = 0; i < tamanhoArray; i++)
                {

                    Console.WriteLine("Título do chamado : ");
                    string strTituloChamados = Console.ReadLine();
                    tituloChamado[i] = strTituloChamados;

                    Console.WriteLine("Descrição do chamado : ");
                    string strDescricaoChamado = Console.ReadLine();
                    descricaoChamado[i] = strDescricaoChamado;

                    Console.WriteLine("Equipamento : ");
                    string strEquipamentoChamado = Console.ReadLine();
                    equipamentoChamado[i] = strEquipamentoChamado;


                    Console.WriteLine("Data de abertura : ");
                    dataAberturaChamado[i] = DateTime.Today.ToString("dd/MM/yyyy");
                    Console.WriteLine(dataAberturaChamado[i]);


                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Chamado cadastrado com sucesso");
                    Console.ResetColor();

                    Console.WriteLine("Digite 1 para continuar cadastrando um chamado ou 2 para sair");

                    string opcaoContinuarChamado = Console.ReadLine();

                    if (opcaoContinuarChamado != "1" || opcaoContinuarChamado == "2")
                    {
                        break;
                    }

                }
            }

            static void EditarChamados()
            {
                Console.WriteLine("Qual id de chamado voce quer editar");
                int idChamadosEditar = int.Parse(Console.ReadLine());

                Console.WriteLine("Título do chamado : ");
                string strTituloChamados = Console.ReadLine();
                tituloChamado[idChamadosEditar] = strTituloChamados;

                Console.WriteLine("Descrição do chamado : ");
                string strDescricaoChamado = Console.ReadLine();
                descricaoChamado[idChamadosEditar] = strDescricaoChamado;

                Console.WriteLine("Equipamento : ");
                string strEquipamentoChamado = Console.ReadLine();
                equipamentoChamado[idChamadosEditar] = strEquipamentoChamado;


                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Produto editado com sucesso");
                Console.ResetColor();
            }

            static void DeletarChamados()
            {
                int idDeletarChamados;
                Console.WriteLine("Qual id de chamados você gostaria de excluir?");

                idDeletarChamados = int.Parse(Console.ReadLine());

                string[] arrayAuxiliarChamados = new string[tamanhoArray];





                arrayAuxiliarChamados[0] = idDeletarChamados.ToString();
                arrayAuxiliarChamados[1] = tituloChamado[idDeletarChamados];
                arrayAuxiliarChamados[2] = descricaoChamado[idDeletarChamados];
                arrayAuxiliarChamados[3] = equipamentoChamado[idDeletarChamados];
                arrayAuxiliarChamados[4] = dataAberturaChamado[idDeletarChamados];
                arrayAuxiliarChamados[5] = diasAbertosChamado[idDeletarChamados];




                for (int i = 0; i < tituloChamadoAuxiliar.Length; i++)
                {
                    if (tituloChamado[i] != arrayAuxiliarChamados[1])
                    {
                        tituloChamadoAuxiliar[i] = tituloChamado[i];
                    }

                }

                for (int i = 0; i < descricaoChamadoAuxiliar.Length; i++)
                {
                    if (descricaoChamado[i] != arrayAuxiliarChamados[2])
                    {
                        descricaoChamadoAuxiliar[i] = descricaoChamado[i];
                    }
                }

                for (int i = 0; i < equipamentoChamadoAuxiliar.Length; i++)
                {
                    if (equipamentoChamado[i] != arrayAuxiliarChamados[3])
                    {
                        equipamentoChamadoAuxiliar[i] = equipamentoChamado[i];
                    }
                }

                for (int i = 0; i < dataAberturaChamadoAuxiliar.Length; i++)
                {
                    if (dataAberturaChamado[i] != arrayAuxiliarChamados[4])
                    {

                        dataAberturaChamadoAuxiliar[i] = dataAberturaChamado[i];

                    }

                }

                for (int i = 0; i < diasAbertosChamadoAuxiliar.Length; i++)
                {
                    if (diasAbertosChamado[i] != arrayAuxiliarChamados[5])
                    {

                        diasAbertosChamadoAuxiliar[i] = diasAbertosChamado[i];
                    }

                }

                for (int j = 0; j < tamanhoArray; j++)
                {
                    tituloChamado[j] = tituloChamadoAuxiliar[j];
                    descricaoChamado[j] = descricaoChamadoAuxiliar[j];
                    equipamentoChamado[j] = equipamentoChamadoAuxiliar[j];
                    dataAberturaChamado[j] = dataAberturaChamadoAuxiliar[j];
                    diasAbertosChamado[j] = diasAbertosChamadoAuxiliar[j];


                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Excluido com sucesso!");
                Console.ResetColor();


            }

            static void HistoricoChamado()
            {


                for (int i = 0; i < tamanhoArray; i++)
                {
                    idChamado = i;


                    dataAberturaChamado[i] = DateTime.Today.ToString("dd/MM/yyyy");

                    dataDiasAbertos = Convert.ToDateTime(dataAberturaChamado[i]);

                    int diasAbertosChamados = Math.Abs((int)dataDiasAbertos.Subtract(DateTime.Today).TotalDays);

                    dataAberturaChamado[i] = diasAbertosChamados.ToString();

                    if (tituloChamado[i] != null)
                    {
                        Console.WriteLine("---------");

                        Console.WriteLine("ID chamado : " + idChamado);

                        Console.WriteLine("Titulo chamado: " + tituloChamado[i]);

                        Console.WriteLine("Descrição chamado: " + descricaoChamado[i]);

                        Console.WriteLine("Equipamento : " + equipamentoChamado[i]);

                        Console.WriteLine("Data abertura : " + dataAberturaChamado[i]);

                        if (diasAbertosChamado[i] != null)
                        {
                            Console.WriteLine("Quantidade de dias aberto " + diasAbertosChamado[i].ToString() + "Dia(s)");

                        }
                        else
                        {
                            break;
                        }


                        Console.WriteLine("---------");

                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Historico Vazio!");
                        break;
                    }
                }


            }

            static void RegistrarEquipamento()
            {
                for (int i = 0; i < tamanhoArray; i++)
                {

                    while (true)
                    {
                        Console.WriteLine("Nome do Equipamento");
                        string strNomeEquipamento = Console.ReadLine();
                        nomeEquipamentos[i] = strNomeEquipamento;



                        if (nomeEquipamentos[i].Length < 6)
                        {
                            Console.WriteLine("Digite no minimo 6 caracteres!");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }

                    Console.WriteLine("Preço de aquisição");
                    double precoAquisicao = Convert.ToDouble(Console.ReadLine());
                    precoEquipamentos[i] = precoAquisicao;





                    Console.WriteLine("Número de série");
                    string strNumeroSerie = Console.ReadLine();
                    numeroSerieEquipamentos[i] = strNumeroSerie;

                    Console.WriteLine("Data de fabricação");
                    string strDataFabricacao = Console.ReadLine();
                    dataFabricacao[i] = strDataFabricacao;

                    Console.WriteLine("Fabricante");
                    string strFabricante = Console.ReadLine();
                    fabricanteEquipamento[i] = strFabricante;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Produto cadastrado com sucesso");
                    Console.ResetColor();

                    Console.WriteLine("Digite 1 para continuar cadastrando... ou 2 para sair");

                    string opcaoContinuar = Console.ReadLine();

                    if (opcaoContinuar != "1")
                    {
                        break;
                    }


                }
            }

            static void EditarEquipamento()
            {
                Console.WriteLine("Qual id voce quer editar");
                int id = int.Parse(Console.ReadLine());


                Console.WriteLine("Nome do Equipamento");
                string strNomeEquipamento = Console.ReadLine();
                nomeEquipamentos[id] = strNomeEquipamento;

                Console.WriteLine("Preço de aquisição");
                double precoAquisicao = Convert.ToDouble(Console.ReadLine());
                precoEquipamentos[id] = precoAquisicao;

                Console.WriteLine("Número de série");
                string strNumeroSerie = Console.ReadLine();
                numeroSerieEquipamentos[id] = strNumeroSerie;

                Console.WriteLine("Data de fabricação");
                string strDataFabricacao = Console.ReadLine();
                dataFabricacao[id] = strDataFabricacao;

                Console.WriteLine("Fabricante");
                string strFabricante = Console.ReadLine();
                fabricanteEquipamento[id] = strFabricante;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Produto editado com sucesso");
                Console.ResetColor();
            }

            static void ExcluirEquipamento()
            {
                int idDeletar;

                Console.WriteLine("Qual id de equipamento você gostaria de excluir?");

                idDeletar = int.Parse(Console.ReadLine());


                string[] arrayAuxiliarEquipamento = new string[tamanhoArray];

                arrayAuxiliarEquipamento[0] = idDeletar.ToString();
                arrayAuxiliarEquipamento[1] = nomeEquipamentos[idDeletar];
                arrayAuxiliarEquipamento[2] = precoEquipamentos[idDeletar].ToString();
                arrayAuxiliarEquipamento[3] = numeroSerieEquipamentos[idDeletar];
                arrayAuxiliarEquipamento[4] = dataFabricacao[idDeletar];
                arrayAuxiliarEquipamento[5] = fabricanteEquipamento[idDeletar];

                for (int j = 0; j < equipamentoChamado.Length; j++)
                {
                    if (j < equipamentoChamado.Length)
                    {
                        if (nomeEquipamentos[idDeletar] == equipamentoChamado[j])
                        {
                            Console.WriteLine("Proibido a exclusão dos itens!");
                            Console.ReadKey();
                            Console.Clear();
                            VisualizarHistorico();
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }


                    for (int i = 0; i < nomeEquipamentosAuxiliar.Length; i++)
                    {
                        if (nomeEquipamentos[i] != arrayAuxiliarEquipamento[1])
                        {
                            nomeEquipamentosAuxiliar[i] = nomeEquipamentos[i];
                        }



                    }

                    for (int i = 0; i < precoEquipamentosAuxiliar.Length; i++)
                    {
                        if (precoEquipamentos[i].ToString() != arrayAuxiliarEquipamento[2])
                        {
                            precoEquipamentosAuxiliar[i] = precoEquipamentos[i];
                        }
                    }

                    for (int i = 0; i < numeroSerieEquipamentosAuxiliar.Length; i++)
                    {
                        if (numeroSerieEquipamentos[i] != arrayAuxiliarEquipamento[3])
                        {
                            numeroSerieEquipamentosAuxiliar[i] = numeroSerieEquipamentos[i];
                        }
                    }

                    for (int i = 0; i < dataFabricacaoAuxilar.Length; i++)
                    {
                        if (dataFabricacao[i] != arrayAuxiliarEquipamento[4])
                        {

                            dataFabricacaoAuxilar[i] = dataFabricacao[i];

                        }

                    }

                    for (int i = 0; i < fabricanteEquipamentoAuxiliar.Length; i++)
                    {
                        if (fabricanteEquipamento[i] != arrayAuxiliarEquipamento[5])
                        {

                            fabricanteEquipamentoAuxiliar[i] = fabricanteEquipamento[i];
                        }

                    }

                    for (int k = 0; k < tamanhoArray; k++)
                    {
                        nomeEquipamentos[k] = nomeEquipamentosAuxiliar[k];
                        precoEquipamentos[k] = precoEquipamentosAuxiliar[k];
                        numeroSerieEquipamentos[k] = numeroSerieEquipamentosAuxiliar[k];
                        dataFabricacao[k] = dataFabricacaoAuxilar[k];
                        fabricanteEquipamento[k] = fabricanteEquipamentoAuxiliar[k];



                    }

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Excluido com sucesso!");
                    Console.ResetColor();

                }
            }

            static void VisualizarHistorico()
            {


                for (int i = 0; i < tamanhoArray; i++)
                {
                    if (nomeEquipamentos[i] != null)
                    {
                        idEquipamento = i;

                        Console.WriteLine("----");

                        Console.WriteLine("ID : " + idEquipamento);

                        Console.WriteLine("O nome é : " + nomeEquipamentos[i]);

                        Console.WriteLine("O numero de serie é : " + numeroSerieEquipamentos[i]);

                        Console.WriteLine("O fabricante é : " + fabricanteEquipamento[i]);

                        Console.WriteLine("----");

                    }
                    else
                    {
                        Console.WriteLine("Histórico vazio!!!");
                        break;
                    }










                }
            }

            static void RegistrarSolicitante()
        {
            for (int i = 0; i < tamanhoArray; i++)
            {

                while (true)
                {

                    Console.WriteLine("Registrando Solicitante : ");



                    Console.WriteLine("Digite o nome do Solicitante : ");

                    string strNomeSolicitante = Console.ReadLine();
                    nomeSolicitante[i] = strNomeSolicitante;

                    if (nomeSolicitante[i].Length < 6)
                    {
                        Console.WriteLine("Digite no minimo 6 caracteres!");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }


                Console.WriteLine("Digite o email do Solicitante : ");
                string strEmailSolicitanteEquipamentos = Console.ReadLine();
                emailSolicitante[i] = strEmailSolicitanteEquipamentos;

                Console.WriteLine("Digite o numero de telefone do Solicitante");
                string strNumeroTelefoneSolicitante = Console.ReadLine();
                numeroTelefoneSolicitante[i] = strNumeroTelefoneSolicitante;


                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Solicitante cadastrado com sucesso");
                Console.ResetColor();

                Console.WriteLine("Digite 1 para continuar cadastrando... ou 2 para sair");

                string opcaoContinuarSolicitante = Console.ReadLine();

                if (opcaoContinuarSolicitante != "1")
                {
                    break;
                }
            }
        }
          
            static void EditarSolicitante()
        {
            int idEditarSolicitante;

            Console.WriteLine("Qual id de solicitante voce quer editar");
            idEditarSolicitante = int.Parse(Console.ReadLine());


            Console.WriteLine("Nome do solicitante");
            string strNomeEquipamento = Console.ReadLine();
            nomeSolicitante[idEditarSolicitante] = strNomeEquipamento;

            Console.WriteLine("email do solicitante");
            double doubleEmailSolicitante = Convert.ToDouble(Console.ReadLine());
            emailSolicitante[idEditarSolicitante] = doubleEmailSolicitante.ToString();

            Console.WriteLine("Número de telefone do solicitante");
            string strEditarNumeroTelefoneSolicitante = Console.ReadLine();
            numeroTelefoneSolicitante[idEditarSolicitante] = strEditarNumeroTelefoneSolicitante;


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Solicitante editado com sucesso");
            Console.ResetColor();
        }

            static void ExcluirSolicitante()
        {
            int idDeletarSolicitante;
            Console.WriteLine("Qual id você gostaria de excluir?");

            idDeletarSolicitante = int.Parse(Console.ReadLine());

            string[] arrayAuxiliarSolicitante = new string[tamanhoArray];

            string[] nomeSolicitanteAuxiliar = new string[tamanhoArray];
            string[] emailSolicitanteAuxiliar = new string[tamanhoArray];
            string[] numeroTelefoneSolicitanteAuxiliar = new string[tamanhoArray];




            arrayAuxiliarSolicitante[0] = idDeletarSolicitante.ToString();
            arrayAuxiliarSolicitante[1] = nomeSolicitante[idDeletarSolicitante];
            arrayAuxiliarSolicitante[2] = emailSolicitante[idDeletarSolicitante];
            arrayAuxiliarSolicitante[3] = numeroTelefoneSolicitante[idDeletarSolicitante];





            for (int i = 0; i < nomeSolicitanteAuxiliar.Length; i++)
            {
                if (nomeSolicitante[i] != arrayAuxiliarSolicitante[1])
                {
                    nomeSolicitanteAuxiliar[i] = nomeSolicitante[i];
                }

            }

            for (int i = 0; i < emailSolicitanteAuxiliar.Length; i++)
            {
                if (emailSolicitante[i] != arrayAuxiliarSolicitante[2])
                {
                    emailSolicitanteAuxiliar[i] = emailSolicitante[i];
                }
            }

            for (int i = 0; i < numeroTelefoneSolicitanteAuxiliar.Length; i++)
            {
                if (numeroTelefoneSolicitante[i] != arrayAuxiliarSolicitante[3])
                {
                    numeroTelefoneSolicitanteAuxiliar[i] = numeroTelefoneSolicitante[i];
                }
            }



            for (int j = 0; j < tamanhoArray; j++)
            {
                nomeSolicitante[j] = nomeSolicitanteAuxiliar[j];
                emailSolicitante[j] = emailSolicitanteAuxiliar[j];
                numeroTelefoneSolicitante[j] = numeroTelefoneSolicitanteAuxiliar[j];

            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Excluido com sucesso!");
            Console.ResetColor();

        }

            static void HistoricoSolicitante()
        {
            for (int i = 0; i < tamanhoArray; i++)
            {
                if (nomeSolicitante[i] != null)
                {
                    idSolicitante = i;

                    Console.WriteLine("----");

                    Console.WriteLine("ID : " + idSolicitante);

                    Console.WriteLine("O nome do solicitante é : " + nomeSolicitante[i]);

                    Console.WriteLine("O email do solicitante é : " + emailSolicitante[i]);

                    Console.WriteLine("O telefone do solicitante é : " + numeroTelefoneSolicitante[i]);

                    Console.WriteLine("----");

                }
                else
                {
                    Console.WriteLine("Histórico vazio!!!");
                    break;
                }










            }
        }
    }
}








#region parte 1
/*Requisito 1.1: Como funcionário, Junior quer ter a possibilidade de registrar equipamentos

• Deve ter um nome com no mínimo 6 caracteres; // ok
• Deve ter um preço de aquisição;//ok
• Deve ter um número de série;///ok
• Deve ter uma data de fabricação;//ok
• Deve ter uma fabricante;//ok


Requisito 1.2: Como funcionário, Junior quer ter a possibilidade de visualizar todos os equipamentos
registrados em seu inventário.

• Deve mostrar o nome;
• Deve mostrar o número de série;
• Deve mostrar a fabricante;

Requisito 1.3: Como funcionário, Junior quer ter a possibilidade de editar um equipamento, sendo
que ele possa editar todos os campos.

• Deve editar um nome com no mínimo 6 caracteres;
• Deve editar um preço de aquisição;
• Deve editar um número de série;
• Deve editar uma data de fabricação;
• Deve editar uma fabricante;

Requisito 1.4: Como funcionário, Junior quer ter a possibilidade de excluir um equipamento que esteja
registrado.

• A lista de equipamentos deve ser atualizada
• Caso o equipamento esteja vinculado num chamado, não deve permitir a exclusão deste
equipamento.

2. Controle de Chamados

Requisito 2.1: Como funcionário Junior quer ter a possibilidade de registrar os chamados de
manutenções que são efetuadas nos equipamentos registrados
• Deve ter a título do chamado;
• Deve ter a descrição do chamado;
• Deve ter um equipamento;
• Deve ter uma data de abertura;

Requisito 2.2: Como funcionário Junior quer ter a possibilidade de visualizar todos os chamados
registrados para controle.
• Deve mostrar o título do chamado;
• Deve mostrar o equipamento;
• Deve mostrar a data de abertura;
• Número de dias que o chamado está aberto

Requisito 2.3: Como funcionário Junior quer ter a possibilidade de editar um chamado que esteja
registrado, sendo que ele possa editar todos os campos.
• Deve ter os mesmos critérios que o Requisito 2.1

Requisito 2.4: Como funcionário Junior quer ter a possibilidade de excluir um chamado.

3. Restrições Técnicas
Deverão utilizar apenas Arrays para o armazenamento das informações dos equipamentos e também
dos chamados, ou seja, não podem utilizar nenhuma classe dos pacotes System.Collections ou
System.Collections.Generic ou System.Linq
Deve ter um menu de opções para a navegação do usuário.
Quantidade de Registros: 1000
*/
#endregion

#region parte 2
/*
PARTE 2 : 

1. Cadastro de Solicitante
 Requisito 1.1: Como funcionário, Junior quer ter a possibilidade de registrar
solicitantes
 • Deve ter um nome com no mínimo 6 caracteres;
 • Deve ter um email
 • Deve ter um número de telefone
 Requisito 1.2: Como funcionário, Junior quer ter a possibilidade de visualizar
todos os solicitantes registrados
 • Deve mostrar o id;
 • Deve mostrar o nome;
 • Deve mostrar o email;
 • Deve mostrar a número de telefone;
 Requisito 1.3: Como funcionário, Junior quer ter a possibilidade de editar um
solicitante, sendo que ele possa editar todos os campos.
 • Deve ter os mesmos critérios que o Requisito 1.

 Requisito 1.4: Como funcionário, Junior quer ter a possibilidade de excluir um
solicitante que esteja registrado.

 • A lista de solicitantes deve ser atualizada
 

2. Alteração no Controle de Chamados
 Requisito 2.1: Como funcionário Junior quer ter a possibilidade de registrar o
solicitante nos chamados de manutenções que são efetuadas nos equipamentos
registrados
 Requisito 2.2: Como funcionário Junior quer ter a possibilidade de visualizar
também o solicitante nos chamados registrados para controle.

 Requisito 2.3: Como funcionário Junior quer ter a possibilidade de editar o
solicitante do chamado que esteja registrado
 Requisito 2.4: Como funcionário Junior quer ter a possibilidade de visualizar
chamados agrupados
 • Os chamados devem ser apresentados de maneira separada pelos status: Abertos e Fechados
3. Alteração no Cadastro de Equipamentos
 Requisito 3.1: Como funcionário Junior quer ter a possibilidade de visualizar os
equipamentos que mais dão problemas

 • Os equipamentos que mais apresentaram problemas devem ser apresentados ordenados em decrescente
 */
#endregion