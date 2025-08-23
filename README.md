# Avaliação e Orientação a Objetos

## 🎯 Objetivo
Programar em Web um **Micro-ondas Digital** utilizando conceitos de orientação a objetos.

---

## 📋 Requisitos Gerais

### Obrigatórios
- A. Utilizar conceitos de **orientação a objetos**.  
- B. **.NET Framework 4.0 ou superior**.  
- C. Não se preocupar com o visual do formulário, mas sim com a implementação do micro-ondas.  
- D. Separar as camadas de **interface de usuário** e **negócio**.  
- E. O programa deve funcionar conforme os requisitos de cada nível.  

### Desejáveis / Diferenciais
- F. Observar os princípios **SOLID**.  
- G. Utilizar **design patterns**.  
- H. Boas práticas e qualidade de código visando legibilidade.  
- I. Prevenir uso incorreto das classes, protegendo acesso a dados e métodos.  
- J. Documentar o código quando necessário.  
- K. Implementar **testes unitários** para a camada de negócio.  

---

## 🏆 Níveis de Desenvolvimento

### 🔹 Nível 1
1. Criar interface para informar **tempo** e **potência**.  
   - Entrada por teclado digital ou input.  
   - Tempo: mínimo **1s**, máximo **2min**.  
   - Potência: **1 a 10** (default = 10).  
   - Conversão automática de segundos em minutos (ex: 90s → 1:30).  

2. **Validações**:  
   - Tempo fora dos limites → mensagem de erro.  
   - Potência inválida (<0 ou >10) → mensagem de erro.  
   - Potência não informada → assumir **10**.  

3. **Início rápido**: sem tempo/potência → 30s e potência 10.  

4. **Acréscimo de tempo**: iniciar durante execução → soma de +30s.  

5. **String de aquecimento**:  
   - Exibida em label, quantidade de caracteres varia conforme potência.  
   - Ao final → "Aquecimento concluído".  

6. **Pausa e cancelamento**:  
   - Botão único pausa/cancela.  
   - Pausa → pode retomar.  
   - Pausado + botão novamente → cancela.  
   - Antes de iniciar → limpa campos.  

---

### 🔹 Nível 2
**Programas de aquecimento pré-definidos (5 programas fixos):**
- Pipoca (3min, potência 7)  
- Leite (5min, potência 5)  
- Carne (14min, potência 4)  
- Frango (8min, potência 7)  
- Feijão (8min, potência 9)  

**Regras:**
- Cada programa tem **caractere de aquecimento único** (não repetir e não usar ".").  
- Não podem ser alterados/excluídos.  
- Selecionar programa → preenche tempo e potência automaticamente.  
- Não permite acrescentar tempo.  
- Pausa/cancelamento permitidos.  

---

### 🔹 Nível 3
**Cadastro de programas customizados:**  
- Campos obrigatórios: nome, alimento, potência, caractere, tempo.  
- Instruções → opcionais.  
- Caractere único (não repetir com pré-definidos nem com ".").  
- Exibidos junto aos pré-definidos, mas em **itálico**.  
- Persistência: **JSON** ou **SQL Server**.  

---

### 🔹 Nível 4
**Exportação de regras para Web API:**  
- Todos os métodos devem ter endpoints.  
- Autenticação com **Bearer Token**.  
- Exibir status da autenticação.  
- Configuração de credenciais com senha mascarada.  
- Senha persistida com **SHA1 (256 bits)**.  
- Connection string do banco **criptografada**.  

**Tratamento de Exceptions:**  
- Mecanismo de resposta em formato padrão.  
- Exception específica para regras de negócio.  
- Exceptions não tratadas → log em arquivo ou banco (Exception, Inner Exception, StackTrace, etc.).  

---

## ✅ Entrega
- No mínimo deve atender os requisitos até o **Nível 3**.  
- Ao entregar, informar qual nível o programa alcança.  
