<template>
    <!-- Modal -->
    <div class="modal" 
        :class="modalType" 
        :id="id">

        <!-- Modal dialog -->
        <div class="modal-dialog" :class="dialogType">

            <!-- Modal content -->
            <div class="modal-content" :class="{
                'modal-content-bg-transparent': transparent
            }">
                <FaButton v-if="dismissable" class="modal-close-button" data-bs-dismiss="modal"
                    fa-icon="fa-solid fa-close" variant="transparent" size="4" aria-label="Close" />

                <div class="modal-custom-content">
                    <component :is="component" 
                        :width="200"
                        :height="200"
                        value="item"/>
                </div>
            </div>
        </div>
    </div>
</template>

<script lang="ts" setup>
import Modal from 'bootstrap/js/src/modal'

interface CommonModalProps {
    id: string;
    modalType: string;
    dialogType: string;
    component: any;
    item?: any;
    transparent?: boolean;
    visible?: boolean;
    dismissable?: boolean;    
}

const props = defineProps<CommonModalProps>()

</script>

<style lang="scss" scoped></style>