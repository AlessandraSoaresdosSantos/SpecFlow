Feature: FeatureSite
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@after
@Browser:Firefox
Scenario: Preencher formulário de site
	Given que eu esteja no site jobmidia
	When eu clicar no link contato
	And  para entrar em contato e necessario informar todos os dados obrigatorios do formulario: Alessandra,ale@hotmail.com,(11)9987-0000,dúvida
	When  eu clicar em Enviar
	Then finizar o site
	