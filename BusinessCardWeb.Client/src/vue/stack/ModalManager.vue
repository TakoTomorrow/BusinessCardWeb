<template>
    <slot/>
    <ProjectModal :item="projectModalTargetItem"
                  @close="_onProjectModalClosed"/>
    <CommonModal 
        id="qrcode-moal"
        modal-type="modal-xl fade"
        dialog-type="modal-dialog-centered"
        :component="commonModalTargetItem?.component"
        :item="commonModalTargetItem?.comment"/>
</template>

<script lang="ts" setup>
import ProjectModal from "../components/modals/project/ProjectModal.vue"
import CommonModal from "../components/modals/base/CommonModal.vue"
import {provide, ref} from "vue"

const projectModalTargetItem = ref(null)
const commonModalTargetItem = ref(null)

const showProjectModal = (articleItem) => {
    projectModalTargetItem.value = articleItem
}

const showCommonModal = (item) => {
    commonModalTargetItem.value = item
}

const _onProjectModalClosed = () => {
    projectModalTargetItem.value = null
}

provide("showProjectModal", showProjectModal)
provide("showCommonModal", showCommonModal)
</script>

<style lang="scss" scoped>
@import "/src/scss/_theming.scss";
</style>