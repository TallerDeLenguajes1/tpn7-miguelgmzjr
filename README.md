2a. La propiedad TabIndex se utiliza para ordenar los controles dentro del formulario con el fin de desplazarnos dentro de él mediante la tecla de tabulación.
2b. Hay dos conceptos principales relacionados con el foco: el foco de teclado y el foco lógico. El foco de teclado hace referencia al elemento que recibe la entrada del teclado, y el foco lógico hace referencia al elemento que tiene el foco en un ámbito de foco.
    - El foco de teclado hace referencia al elemento que recibe actualmente la entrada del teclado. Puede haber un único elemento en todo el escritorio que tenga el foco de teclado.
3b. Un evento es la capacidad que tiene un objeto de notificar al programa cuando ocurre algo. hay 3 eventos relacionados con el teclado que pueden ocurrir en un control. La secuencia siguiente muestra el orden general de los eventos:
    - El usuario presiona la tecla "a", la clave se preprocesa, se envía y se produce un KeyDown evento.
    - El usuario mantiene presionada la tecla "a", la clave se preprocesa, se envía y se produce KeyPress un evento.
    - El usuario suelta la tecla "a", la clave se preprocesa, se envía y se produce un KeyUp evento.
