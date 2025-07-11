<template>    
    <button :class="`btn btn-${props.btnStyle}`"
        @click="_click">
        <i :class="`fa ${props.faIcon}`"></i>
        <span v-if="props.literal">{{ props.literal }}</span>
    </button>
</template>

<script lang="ts" setup>
import _ from 'lodash';

interface FaLiteralButtonProps {
    faIcon: string
    btnStyle: string
    literal: string
    onClieckEvent: () => void
}

const props = defineProps<FaLiteralButtonProps>()

const _click = () => {
    props.onClieckEvent();
}
</script>

<style lang="scss" scoped>
button > i{
    margin-right: 5px;
}
</style>