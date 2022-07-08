<template>
    <div id="app">
        <CustomHeader></CustomHeader>
        <Home msg="Hello world!" />
    </div>
</template>

<script>
    import Home from './components/Home.vue';
    import CustomHeader from './components/shared/CustomHeader.vue';

    export default {
        name: 'app',
        components: {
            Home,
            CustomHeader
        }
    };


</script>

<style>
</style>

