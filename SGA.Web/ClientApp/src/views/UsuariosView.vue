<template>
    <div>
        <h1>Usuarios</h1>

        <button @click="cargarUsuarios">
            Cargar Usuarios
        </button>

        <table border="1">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Nombre</th>
                </tr>
            </thead>

            <tbody>
                <tr v-for="usuario in usuarios" :key="usuario.id">
                    <td>{{ usuario.id }}</td>
                    <td>{{ usuario.nombre }}</td>
                </tr>
            </tbody>
        </table>
    </div>
</template>

<script>
import api from '../services/ApiService'

export default {
    name: 'UsuariosView',

    data() {
        return {
            usuarios: []
        }
    },

    methods: {
        async cargarUsuarios() {
            try {
                const response = await api.get('/Usuario')

                console.log("RESPUESTA:", response)
                console.log("DATOS:", response.data)

                this.usuarios = response.data
            }
            catch (error) {
                console.error("ERROR:", error)
            }
        }
    }
}
</script>
