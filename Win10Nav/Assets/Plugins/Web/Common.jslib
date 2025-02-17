mergeInto(LibraryManager.library,{
    IsPhone: function(){
        let info=navigator.userAgent;
        let isPhone=/mobile/i.test(info);
        return isPhone;
    },
    Printf: function(msg){
        console.log(msg);
    }
});