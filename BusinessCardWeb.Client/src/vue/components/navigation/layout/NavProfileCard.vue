<template>
    <div class="nav-profile-card" :class="{'nav-profile-card-shrink': shrink}">
        <img class="logo" src="/public/images/pictures/ASML.png" alt="ASML Logo" />
        <ImageView :src="avatar"
                   :alt="name"
                   :resolve-path="true"
                   class="nav-profile-card-image-view"
                   image-class="rounded-circle"/>

        <h4 class="nav-profile-card-title"
            v-if="includeToggleButton"
            v-html="name"/>

        <h6 class="nav-profile-card-role"
            v-if="includeToggleButton"
            v-html="role"/>

        <NavToggleButton v-if="includeToggleButton"
                         :toggled="shrink"
                         @click="_onToggleButton"/>
        <div class="nav-profile-card-btns"
            v-if="isMobileLayout">          
            <FaLiteralButton faIcon="fa fa-qrcode"
                        btnStyle="primary"
                        literal=""                        
                        :on-clieck-event="_showQrcode"/>  
            <FaLiteralButton faIcon="fa fa-share-alt"
                        btnStyle="primary"
                        :literal = "isMobileLayout ? '分享連結':'複製連結'"
                        :on-clieck-event="_shareUrl"/>
        </div>
    </div>
</template>

<script lang="ts" setup>
import ImageView from "./../../widgets/ImageView.vue"
import NavToggleButton from "./NavToggleButton.vue"
import FaLiteralButton from "./../../widgets/FaLiteralButton.vue"
import {inject} from "vue"
import QRCodeVue3 from "qrcode-vue3"

const props = defineProps({
    shrink: Boolean,
    avatar: String,
    name: String,
    role: String,
    includeToggleButton: Boolean
})

const isMobileLayout:boolean = inject("isMobileLayout")
const showCommonModal:(item : any)=>void =inject("showCommonModal")
const urlToShare:string = window.location.href

const emit = defineEmits(['toggle'])

const _onToggleButton = () => {
    emit('toggle')
}

const _shareUrl = () => {    
    if(isMobileLayout){
        navigator.share({
            title: "測試標題",
            text: "分享我的名片",
            url: urlToShare
        })        
        .catch(err  => {
            if(err.name != "AbortError"){
                console.error("無法分享連結", err)
                alert("無法分享連結")
            }        
        })
    }
    else{
        navigator.clipboard.writeText(urlToShare)
        .then(() => {
            alert("已複製連結到剪貼簿")
        })
        .catch(err => {
            console.error("無法複製連結到剪貼簿", err)
            alert("無法複製連結到剪貼簿")
        })
    }    
}

const _showQrcode = () => {
    showCommonModal({component : QRCodeVue3, comment : urlToShare});
}
</script>

<style lang="scss" scoped>
@import "/src/scss/_theming.scss";

div.nav-profile-card {
    display: flex;
    width: 100%;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    padding: 20px;
    color: $nav-contrast;
    position: relative;    
    @include media-breakpoint-down($navigation-sidebar-breakpoint) {
        padding: 10px;
        height: clamp(170px,30.3vh,200px);
    }

    img.logo {
        @include media-breakpoint-up(sm) {
            display: none;
        }
        position: absolute;
        top: 0px
    }
}

div.nav-profile-card-image-view {
    --max-height:clamp(130px, 22.5vh, 160px);
    --border-width:3px;

    @include media-breakpoint-down(lg) {
        --max-height:140px;
    }

    @include media-breakpoint-down(sm) {
        --border-width: 2px;
        --max-height: clamp(120px, 19.5vh, 150px);
        position: absolute;
        bottom: 5px;
        left: 5px;
    }

    min-width: calc(var(--max-height)/2);
    min-height: calc(var(--max-height)/2);
    width: var(--max-height);
    height: var(--max-height);
    //border: var(--border-width) solid $nav-avatar-border-color;
    padding: 4px;
    border-radius: 50%;

    overflow: hidden;
    user-select: none;
    pointer-events: none;
}

h4.nav-profile-card-title {
    margin-top: 17px;
    text-transform: uppercase;
    opacity: 0.95;
    letter-spacing: 0.15rem;
    font-size: 1.25rem;
    text-align: center;
    
    @media (max-height: 660px) {
        margin-top: 15px;
        font-size: 1.175rem;
        margin-bottom: 5px;
    }

    @media (max-height: 580px) {
        margin-top: 12px;
        font-size: 1.1rem;
    }

    @include media-breakpoint-down($navigation-sidebar-breakpoint) {
        margin-top: 5px;
        font-size: 1.1rem;
    }

    @include media-breakpoint-down(sm) {
        font-size: 1.05rem;
        position: absolute;
        bottom: 10px;
    }
}

h6.nav-profile-card-role {
    font-size: 1rem;
    color: $nav-highlight;
    opacity: 0.9;
    margin-bottom: 0;

    @media (max-height: 660px) {
        font-size: 0.95rem;
    }

    @media (max-height: 580px) {
        font-size: 0.9rem;
    }

    @include media-breakpoint-down($navigation-sidebar-breakpoint) {
        font-size: 0.95rem;
    }

    @include media-breakpoint-down(sm) {
        font-size: 0.9rem;
    }
}

button.nav-toggle-button {
    position: absolute;
    top: clamp(110px, 20vh, 140px);
    left: 90px;
    @include media-breakpoint-down(xl) {
        left: 75px;
    }
}

div.nav-profile-card-shrink {
    h4.nav-profile-card-title, h6.nav-profile-card-role {
        display: none;
    }

    div.nav-profile-card-image-view {
        width: calc($nav-sidebar-width-shrink - 30px);
        height: calc($nav-sidebar-width-shrink - 30px);
        border-width: 2px;
        padding: 3px;
    }

    button.nav-toggle-button {
        position: absolute;
        top: 80px;
        left: 80px;
    }
}

div.nav-profile-card-btns {
    position: absolute;
    right: clamp(0px, 5vw, 10px);
    bottom: clamp(0px, 5vw, 10px);
    i {
        margin-right: 5px;
    }

    .btn{
        margin-left: 10px;
    }
}
</style>