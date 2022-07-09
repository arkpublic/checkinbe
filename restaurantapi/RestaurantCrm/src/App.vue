<template>
    <div id="app">
        <CustomHeader></CustomHeader>
        <Home msg="Hello world!" />
        <Restaurant></Restaurant>
        <br /><br /><br />
        <Menus></Menus>
    </div>
</template>

<script>
    import Home from './components/Home.vue';
    import CustomHeader from './components/shared/CustomHeader.vue';
    import Restaurant from './components/Restaurant.vue';
    import Menus from './components/Menus.vue';
    export default {
        name: 'app',
        components: {
            Home,
            CustomHeader,
            Restaurant,
            Menus
        }
    };


</script>

<style>
</style>

