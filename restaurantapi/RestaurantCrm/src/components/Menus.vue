<template>
    <div>
        <b-table striped hover :items="items" :fields="fields"></b-table>
    </div>
</template>

<script>
    export default {
        data() {
            return {
                // Note `isActive` is left out and will not appear in the rendered table
                fields: [
                    'numero',
                    'titulo',
                    'subtitulo',
                    'precio',
                    'porciones',
                    'activo',          
                ],
                items: [
                    {
                        numero: 1,
                        titulo: 'carne',
                        subtitulo: '687',
                        precio: '436',
                        porciones: '1',
                        activo: 'si'
                    },
                    {
                        numero: 1,
                        titulo: 'peperoni',
                        subtitulo: '578',
                        precio: '678',
                        porciones: '8  ',
                        activo: 'si'
                    },
                    {
                        numero: 1,
                        titulo: 'camaron',
                        subtitulo: '667',
                        precio: 'si',
                        activo: 'si'
                    },
                    {
                        numero: 1,
                        titulo: 'choriso',
                        subtitulo: '674',
                        precio: '567',
                        porciones: '678',
                        activo: 'si'
                    },

                ]
            }
        }
    }
</script>