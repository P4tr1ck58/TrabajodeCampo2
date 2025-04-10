Algoritmo PerfilEstudiante
	Definir ncursos, notas, dias, horas, ansie, reportD, tiempo, motiva, hRedes Como Entero
	Definir prom, ingresosH Como Real
	Definir asis, suma, Cursoaprobada, Cursodesaprobada Como Entero
	Definir nombre, cursos, notaStr, asiStr, horasSu, ansiedad, actividad Como Cadena
	Definir reportes, ingresos, tiemEstudio, acceso, motivacion, horasRedes Como Cadena
	Dimensionar asiste(100)
	suma <- 0
	Cursoaprobada <- 0
	Cursodesaprobada <- 0
	Escribir '---- Bienvenido -----'
	Escribir '---- Ingrese el nombre del Alumno'
	Escribir '---- Nombre: '
	Leer nombre
	Escribir '---- Hola ', nombre, ', Bienvenido al sistema de perfiles ----'
	Escribir '---- ¿Cuantos cursos está llevando?'
	Leer cursos
	ncursos <- ConvertirANumero(cursos)
	Escribir '---- Notas de los cursos ----'
	Para i<-1 Hasta ncursos Con Paso 1 Hacer
		Escribir '---- Ingrese ', i, '° Nota:'
		Leer notaStr
		notas <- ConvertirANumero(notaStr)
		suma <- suma+notas
	FinPara
	prom <- suma/ncursos
	Escribir '---- Asistencia de los cursos ----'
	Escribir '---- Ingrese valores del 0 al 100'
	Para i<-1 Hasta ncursos Con Paso 1 Hacer
		Escribir '---- Asistencia del ', i, '° curso:'
		Leer asiStr
		asis <- ConvertirANumero(asiStr)
		Si asis>=0 Y asis<=100 Entonces
			asiste[i] <- asis
			Escribir 'Su asistencia es correcta'
		SiNo
			Escribir 'Valor incorrecto. Ingrese un valor entre 0 y 100'
		FinSi
	FinPara
	Para i<-1 Hasta ncursos Con Paso 1 Hacer
		notas <- asiste[i]
		Si notas>=11 Y notas<=20 Entonces
			Escribir 'Curso ', i, ' aprobado'
			Cursoaprobada <- Cursoaprobada+1
		SiNo
			Escribir 'Curso ', i, ' desaprobado'
			Cursodesaprobada <- Cursodesaprobada+1
		FinSi
	FinPara
	Escribir '---- Cursos desaprobados: ', Cursodesaprobada
	Escribir '---- Horas de Sueño ----'
	Escribir '---- ¿Cuántas horas duerme por noche?'
	Leer horasSu
	horas <- ConvertirANumero(horasSu)
	Escribir '---- Nivel de Ansiedad ----'
	Escribir '---- Ingrese su nivel de ansiedad (1 a 5):'
	Leer ansiedad
	ansie <- ConvertirANumero(ansiedad)
	Si ansie<3 Entonces
		Escribir 'Su nivel de ansiedad es bajo'
	SiNo
		Si ansie>3 Y ansie<=5 Entonces
			Escribir 'Su nivel de ansiedad es alto'
		FinSi
	FinSi
	Escribir '---- Actividades Extracurriculares ----'
	Escribir '---- ¿Participa en actividades extracurriculares? (Si/No)'
	Leer actividad
	Si actividad='Si' Entonces
		Escribir '¡Felicitaciones!'
	SiNo
		Si actividad='No' Entonces
			Escribir 'No participa en actividades'
		SiNo
			Escribir 'Introduzca solo Si o No'
		FinSi
	FinSi
	Escribir '---- Reportes Disciplinarios ----'
	Escribir '---- Ingrese el número de reportes disciplinarios:'
	Leer reportes
	reportD <- ConvertirANumero(reportes)
	Si reportD<=5 Entonces
		Escribir 'Su nivel de disciplina es alto'
	SiNo
		Escribir 'Su nivel de disciplina es bajo'
	FinSi
	Escribir '---- Ingresos del Hogar ----'
	Escribir '---- Ingrese sus ingresos mensuales:'
	Leer ingresos
	ingresosH <- ConvertirANumero(ingresos)
	Si ingresosH>2000 Entonces
		Escribir 'Sus ingresos son altos'
	SiNo
		Si ingresosH>=1000 Y ingresosH<=2000 Entonces
			Escribir 'Sus ingresos son medios'
		SiNo
			Escribir 'Sus ingresos son bajos'
		FinSi
	FinSi
	Escribir '---- Tiempo de estudio ----'
	Escribir '---- Ingrese el tiempo de estudio semanal (en horas):'
	Leer tiemEstudio
	tiempo <- ConvertirANumero(tiemEstudio)
	Escribir '---- Acceso a Internet ----'
	Escribir '---- ¿Tiene acceso a internet? (Si/No)'
	Leer acceso
	Si acceso='Si' Entonces
		Escribir 'Acceso a internet'
	SiNo
		Si acceso='No' Entonces
			Escribir 'No tiene acceso a internet'
		SiNo
			Escribir 'Introduzca solo Si o No'
		FinSi
	FinSi
	Escribir '---- Motivación ----'
	Escribir '---- Ingrese su nivel de motivación (1 a 5):'
	Leer motivacion
	motiva <- ConvertirANumero(motivacion)
	Si motiva>=1 Y motiva<=5 Entonces
		Escribir 'Su nivel de motivación es: ', motiva
	SiNo
		Escribir 'Ingrese un valor entre 1 y 5'
	FinSi
	Escribir '---- Redes Sociales ----'
	Escribir '---- ¿Cuántas horas pasa en redes sociales por día?'
	Leer horasRedes
	hRedes <- ConvertirANumero(horasRedes)
	Si prom>=18 Y prom<=20 Entonces
		Si asis=100 Y Cursodesaprobada=0 Y horas>=8 Y ansie<3 Y actividad='Si' Y reportD=0 Y ingresosH>2000 Y tiempo>=10 Y acceso='Si' Y motiva>=4 Y hRedes<=2 Entonces
			Escribir '---- Felicitaciones, usted ', nombre, ' es un Candidato a mención honorífica ----'
		FinSi
	SiNo
		Si prom>=15 Y prom<18 Entonces
			Si asis>=80 Y Cursodesaprobada=0 Y horas>=7 Y ansie<4 Y actividad='Si' Y reportD<=3 Y ingresosH>2000 Y tiempo<=5 Y acceso='Si' Y motiva>=3 Y hRedes<=2 Entonces
				Escribir '---- Felicitaciones, usted ', nombre, ' es Estudiante equilibrado ----'
			FinSi
			// Estudiante equilibrado (sin actividad)
			Si actividad='No' Y reportD<=3 Y ingresosH>=1000 Y ingresosH<=2000 Y tiempo<=5 Y acceso='Si' Y motiva>=3 Y hRedes<=2 Entonces
				Escribir '---- Felicitaciones, usted ', nombre, ' es Estudiante equilibrado ----'
			FinSi
		FinSi
	FinSi
	Si prom>=12 Y prom<14 Entonces
		Si asis<=70 Y Cursodesaprobada=0 Y horas>=7 Y ansie<=4 Y actividad='No' Y reportD>=3 Y ingresosH<=1000 Y tiempo>=0 Y tiempo<5 Y acceso='No' Y motiva<3 Y hRedes>2 Entonces
			Escribir '---- Usted ', nombre, ' es Estudiante con Riesgo Medio ----'
		FinSi
	FinSi
	Si prom<11 Entonces
		Si asis<50 Y Cursodesaprobada=0 Y horas<6 Y ansie=5 Y actividad='No' Y reportD>=3 Y ingresosH<1000 Y tiempo<=3 Y acceso='No' Y motiva=1 Y hRedes>4 Entonces
			Escribir '---- Usted ', nombre, ' es Estudiante en Situación Crítica ----'
		FinSi
	FinSi
FinAlgoritmo
