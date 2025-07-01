<template>
    <ul class="inline-list eq-h4">
        <li v-for="item in items" class="inline-list-item">
            <a class="link-disabled">
                <i v-if="item.faIcon" :class="item.faIcon"/>
                <span v-html="item.value"/>
            </a>
         </li>
    </ul>
    <hr/>
</template>

<script lang="ts" setup>
import JobTitle from "./../../../../src/models/JobTitle"
const props = defineProps({
    items: Array<JobTitle>,
})
</script>

<style lang="scss" scoped>
@import "/src/scss/_theming.scss";

$spacing-between-items:15px;

ul.inline-list {
    list-style: none;
    padding: 0;
    display: flex;

    @include media-breakpoint-down(xl) {
        flex-direction: column;
    }
}

li.inline-list-item {
    margin-right: $spacing-between-items;
    &:not(:last-child)::after {
        content: "𐄁";
        opacity: 0.4;
        margin-left: $spacing-between-items;
    }

    i {
        margin-right: 10px;
        opacity: 1;
    }
}

li.inline-list-item {
    @include media-breakpoint-down(xl) {
        i {
            min-width: 20px;
            text-align: center;
        }

        &:not(:last-child) {
            margin-bottom: 5px;
        }

        &::after {
            display: none!important;
        }
    }
}
</style>