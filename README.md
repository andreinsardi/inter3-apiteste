# inter3-apiteste


Material de consulta para projeto interdisciplinar 

Aqui algumas referências  que podem te ajudar!


### Links úteis 


## GUIA RÁPIDO -> GIT & GITHUB
### Instalando Git 
    - https://git-scm.com/download

---------------------------------

### Obtenha um repositório
    /*crie uma cópia de trabalho em um repositório local executando o comando*/
     - git clone /caminho/para/o/repositório

    /*quando usar um servidor remoto, seu comando será*/
    - git clone usuário@servidor:/caminho/para/o/repositório

---------------------------------

### Adicionando Arquivos:
     /*adiciona todos os arquivos alterado e criados*/   
     - git add . 

     /*registra a alteração*/   
     - git commit -m "comentários das alterações"

Obs: Git é o sistema de versionamento de arquivos Github é o repositório online para guardar estes arquivos 
o comando "git commit" garente o versionamento NÃO garente que os arquivos estão no Github

### Fazendo upload dos arquivos:
    /*Faz upload na master*/
     - git push

---------------------------------

### Ramificando (trabalhando com branch`s):

    /*Quando você está trabalhando em equipe e mais de uma pessoa altera o mesmo projeto, é recomendável que cada alteração tenha sua própria Branch*/

    /*Branches ("ramos") são utilizados para desenvolver funcionalidades isoladas umas das outras. O branch master é o branch "padrão" quando você cria um repositório. Use outros branches para desenvolver e mescle-os (merge) ao branch master após a conclusão. */

    /*crie um novo branch chamado "funcionalidade_x" e selecione-o usando*/
     - git checkout -b funcionalidade_x

     /*retorne para o master usando*/
     - git checkout master

     /*remova o branch da seguinte forma*/
     - git branch -d funcionalidade_x

     /*um branch não está disponível a outros a menos que você envie o branch para seu repositório remoto*/
      - git push origin <funcionalidade_x>

### Atualizar e mesclar (merge):
     /*para atualizar seu repositório local com a mais nova versão, execute de dentro da pasta do projeto*/
     - git pull

     /* sua pasta de trabalho para obter e fazer merge (mesclar) alterações remotas.
        para fazer merge de um outro branch ao seu branch ativo (ex. master), use*/
     - git merge <branch>

     /*em ambos os casos o git tenta fazer o merge das alterações automaticamente. Infelizmente, isto nem sempre é possível e resulta em conflitos. Você é responsável por fazer o merge estes conflitos manualmente editando os arquivos exibidos pelo git. Depois de alterar, você precisa marcá-los como merged com*/
      - git add <arquivo>

      /*antes de fazer o merge das alterações, você pode também pré-visualizá-as usando*/
     - git diff <branch origem> <branch destino>
