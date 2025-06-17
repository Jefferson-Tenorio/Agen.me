# Agen.me
API para agendar serviços, gerenciar clientes, horários e profissionais — em .NET.

# 🗓️ Agen.me — API de Agendamento Inteligente

**Agen.me** é uma API poderosa, escalável e simples de usar, desenvolvida em **.NET**, que permite gerenciar **agendamentos de serviços** para diferentes profissionais, negócios ou empresas.

Essa API foi projetada para ser o coração de plataformas como barbearias, clínicas, oficinas, consultórios, personal trainers e qualquer serviço que dependa de agendamentos organizados, dinâmicos e inteligentes.

---

## 🚀 Visão Geral

Com Agen.me você pode:

- ✅ Cadastrar usuários (clientes e profissionais)
- ✅ Criar e gerenciar serviços oferecidos
- ✅ Definir horários de atendimento
- ✅ Gerenciar agendamentos de forma intuitiva
- ✅ Consultar disponibilidade em tempo real
- ✅ Garantir que não haja conflitos de horário
- ✅ Manter seus dados seguros com autenticação JWT

---

## 🏛️ Arquitetura

O projeto segue princípios de **Clean Architecture**, com separação clara entre:

- 🔹 **API (Presentation)** → Controllers (camada HTTP)
- 🔸 **Application** → Regras de negócio, serviços, validações
- 🔹 **Domain** → Entidades e regras de domínio
- 🔸 **Infrastructure** → Acesso a banco, repositories
- 🔹 **Tests** → Testes unitários e de integração

---

## 🔗 Tecnologias Utilizadas

- 🏗️ **.NET 8 (ASP.NET Core)**
- 🗄️ **Entity Framework Core**
- 🔐 **Autenticação JWT**
- 📄 **Swagger para documentação**
- 🗃️ **SQL Server** (ou compatível: PostgreSQL, MySQL)
- 📦 **Docker Ready (opcional)**

---

## 🔥 Funcionalidades

| 🔧 Funcionalidade | 🎯 Descrição |
|--------------------|--------------|
| 👥 **Usuários** | Cadastro e autenticação (Cliente ou Profissional) |
| ✂️ **Serviços** | Criação e gestão dos serviços oferecidos (Ex.: corte, revisão, consulta) |
| 📅 **Agenda** | Definição dos horários de trabalho dos profissionais |
| 🕐 **Disponibilidade** | Cálculo automático de horários disponíveis |
| 📌 **Agendamento** | Criação, alteração, cancelamento e listagem de agendamentos |
| 🏛️ **Administração** | Gerenciamento completo dos dados (opcional para admins) |

---

## 🗺️ Estrutura de Diretórios

```plaintext
/src
 ┣ 📁AgenMe.API              → API HTTP
 ┣ 📁AgenMe.Application      → Lógica de negócio (Services, DTOs, Validations)
 ┣ 📁AgenMe.Domain           → Entidades, enums e contratos
 ┣ 📁AgenMe.Infrastructure   → Acesso a dados (Repositories, Migrations)
 ┗ 📁AgenMe.Tests            → Testes
