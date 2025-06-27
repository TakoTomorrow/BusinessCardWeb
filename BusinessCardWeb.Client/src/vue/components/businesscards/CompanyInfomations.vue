<template>
    <ul class="inline-list eq-h4">
        <!-- <li v-for="item in items" class="inline-list-item">
            <a :class="item.href ? `link-darkened` : `link-disabled`" :href="item.href">
                <i v-if="item.faIcon" :class="item.faIcon"/>
                <span v-html="item.getValue(true)"/>
            </a>
         </li> -->
        <li class="inline-list-item">
            <a class="link-disabled">
                <i class="fa fa-building"/>
                <span>高盛集團 專業投資經理</span>
            </a>
        </li>
        <li class="inline-list-item">
            <a class="link-disabled">
                <i class="fa fa-dollar-sign"/>
                <span>加密貨幣交易講師</span>
            </a>
        </li>
    </ul>
    <hr/>
</template>

<script setup>
const props = defineProps({
    items: Array,
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