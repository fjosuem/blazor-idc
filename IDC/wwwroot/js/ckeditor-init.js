window.initializeCKEditor = (editorId, dotNetHelper) => {
    ClassicEditor
        .create(document.querySelector(`#${editorId}`), {
            toolbar: [
                'heading', '|',
                'bold', 'italic', 'link', '|',
                'fontColor', 'fontBackgroundColor', '|',
                'bulletedList', 'numberedList', '|',
                'insertTable', 'blockQuote'
            ],
            fontColor: {
                colors: [
                    {
                        color: 'hsl(0, 0%, 0%)',
                        label: 'Black'
                    },
                    {
                        color: 'hsl(0, 0%, 30%)',
                        label: 'Dim grey'
                    },
                    {
                        color: 'hsl(0, 0%, 60%)',
                        label: 'Grey'
                    },
                    {
                        color: 'hsl(0, 0%, 90%)',
                        label: 'Light grey'
                    },
                    {
                        color: 'hsl(0, 75%, 60%)',
                        label: 'Red'
                    },
                    {
                        color: 'hsl(30, 75%, 60%)',
                        label: 'Orange'
                    },
                    {
                        color: 'hsl(60, 75%, 60%)',
                        label: 'Yellow'
                    },
                    {
                        color: 'hsl(90, 75%, 60%)',
                        label: 'Light green'
                    }
                ]
            },
            fontBackgroundColor: {
                colors: [
                    {
                        color: 'hsl(0, 0%, 0%)',
                        label: 'Black'
                    },
                    {
                        color: 'hsl(0, 0%, 30%)',
                        label: 'Dim grey'
                    },
                    {
                        color: 'hsl(0, 0%, 60%)',
                        label: 'Grey'
                    },
                    {
                        color: 'hsl(0, 0%, 90%)',
                        label: 'Light grey'
                    },
                    {
                        color: 'hsl(0, 75%, 60%)',
                        label: 'Red'
                    },
                    {
                        color: 'hsl(30, 75%, 60%)',
                        label: 'Orange'
                    },
                    {
                        color: 'hsl(60, 75%, 60%)',
                        label: 'Yellow'
                    },
                    {
                        color: 'hsl(90, 75%, 60%)',
                        label: 'Light green'
                    }
                ]
            },
            allowedContent: true
        })
        .then(editor => {
            // Guardar la instancia del editor para usarla después
            window.editorInstance = editor;

            // Detectar cambios en el contenido
            const data = editor.getData();
            editor.model.document.on('change:data', () => {
                dotNetHelper.invokeMethod('OnContentChanged', data);
            });
            editor.setData(decodeEscapedHtml(data));

        })
        .catch(error => {
            console.error(error);
        });
};

function decodeEscapedHtml(encodedString) {
    // 1. Reemplazar las secuencias \\< con < y \\> con >
    let intermediateString = encodedString.replace(/\\</g, "<").replace(/\\>/g, ">");

    // 2. Decodificar cualquier entidad HTML (por ejemplo, &lt;, &gt;, etc.)
    const textArea = document.createElement("textarea");
    textArea.innerHTML = intermediateString;

    return textArea.value;
}

//window.setEditorContent = (editorId, content) => {
//    const editor = window.editorInstance; // Usar la instancia global del editor
//    if (editor) {
//        const decodedContent = decodeURIComponent(content); // Decodificar el contenido
//        editor.setData(decodedContent);  // Establecer el contenido en el editor
//    } else {
//        console.error(`Editor con id ${editorId} no encontrado`);
//    }
//};
