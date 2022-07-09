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
                    'nombre',
                    'telefono',
                    'domicilio',
                    'esta_activo',
                ],
                items: [
                    {
                        numero: 1,
                        nombre: 'mcdonals',
                        telefono: '234',
                        domicilio: 'sonora',
                        esta_activo: 'si'
                    },
                    {
                        numero: 5,
                        nombre: 'dominos',
                        telefono: '567',
                        domicilio: 'hermocillo',
                        esta_activo: 'si'
                    },
                    {
                        numero:8,
                        nombre: 'comida china',
                        telefono: '259',
                        domicilio: 'canada',
                        esta_activo: 'si'
                    },
                    {
                        numero:  9,
                        nombre: 'pizzammm',
                        telefono: '146',
                        domicilio: 'mexico',
                        esta_activo: 'si'
                    }

                ]
            }
        }
    }
</script>