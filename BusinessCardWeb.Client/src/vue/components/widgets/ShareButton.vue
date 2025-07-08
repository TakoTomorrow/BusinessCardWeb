<template>    
    <button class="btn btn-primary nav-profile-share" @click="share">
        <i class="fa fa-share-alt"></i>
        <span>{{ shareSupported && isMobileDevice ? '分享連結' : '複製連結' }}</span>
    </button>
</template>

<script lang="ts" setup>
const isMobileDevice = /Mobi|Android|iPhone|iPad|iPod/i.test(navigator.userAgent)
const shareSupported = 'share' in navigator
const urlToShare = window.location.href

const share = () => {    
    if(shareSupported && isMobileDevice){
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
</script>

<style lang="scss" scoped>
button.nav-profile-share {
    position: absolute;
    right: clamp(0px, 5vw, 10px);
    bottom: clamp(0px, 5vw, 10px);
    i {
        margin-right: 5px;
    }
}
</style>