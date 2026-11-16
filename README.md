# 🎉 Cadastro de Eventos – .NET MAUI

Aplicativo desenvolvido em **.NET MAUI** para cadastrar eventos, como atividade da disciplina de Desenvolvimento de Sistemas (Programação Mobile). O projeto demonstra o uso de **BindingContext** e **StringFormat** para exibir os dados cadastrados.

## 📱 Telas do aplicativo

| Tela | Arquivo | Descrição |
|---|---|---|
| 1 | `Views/BoasVindas` | Mensagem de boas-vindas e botão para iniciar o cadastro |
| 2 | `Views/CadastroEvento` | Formulário com os dados do evento |
| 3 | `Views/ConfirmacaoEvento` | Exibe os dados informados para conferência e confirmação |
| 4 | `Views/Obrigado` | Agradecimento e botão para fazer um novo cadastro |

### Campos do cadastro
- Nome do evento
- Data de início
- Data de término
- Número de participantes
- Local do evento
- Custo por participante

## 🔄 Fluxo de navegação

```
Boas-vindas → Cadastro → Confirmação → Obrigada
     ↑                        │             │
     │                        └─ Corrigir ──┤ (volta ao cadastro)
     └───────── Novo cadastro ──────────────┘
```

## 🧠 Conceitos utilizados

- **BindingContext**: ao avançar do cadastro para a confirmação, um objeto `Evento` é criado e definido como `BindingContext` da tela seguinte, que passa a ler suas propriedades.
- **StringFormat**: formata os dados na tela de confirmação, por exemplo:
  - Datas: `{Binding DataInicio, StringFormat='Início: {0:dd/MM/yyyy}'}`
  - Moeda: `{Binding CustoTotal, StringFormat='Custo total: {0:C}'}`
- **Navegação** com `PushAsync`, `PopAsync` e `PopToRootAsync`.
- **Validação** dos campos (nome, participantes, local e custo) com mensagens de alerta.
- **Propriedades calculadas** no modelo: duração em dias e custo total.

## 📂 Estrutura do projeto

```
CadastroEventos
├── AppShell.xaml
├── Models
│   └── Evento.cs
└── Views
    ├── BoasVindas.xaml / .xaml.cs
    ├── CadastroEvento.xaml / .xaml.cs
    ├── ConfirmacaoEvento.xaml / .xaml.cs
    └── Obrigado.xaml / .xaml.cs
```

## ▶️ Como executar

**Requisitos**
- Visual Studio 2022 (ou superior) com a carga de trabalho **Desenvolvimento de interface do usuário multiplataforma do .NET (MAUI)**
- Modo de Desenvolvedor ativado no Windows (para executar em *Windows Machine*)

**Passos**
1. Clone o repositório:
   ```bash
   git clone <URL-DO-SEU-REPOSITORIO>
   ```
2. Abra o arquivo `.sln` no Visual Studio.
3. Selecione **Windows Machine** (ou um emulador Android) no seletor de execução.
4. Pressione **F5** para executar.

## 🖼️ Capturas de tela

As capturas de tela do funcionamento do aplicativo estão no arquivo PDF enviado junto com este projeto.

## 👩‍💻 Autoria

- **Desenvolvedora:** Ana Dantas
- Técnico em Desenvolvimento de Sistemas
- **Ano:** 2026
