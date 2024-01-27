mergeInto(LibraryManager.library, {

  ADSRewardEgle: function () {
    ysdk.adv.showRewardedVideo({
    callbacks: {
        onOpen: () => {
          console.log('Video ad open.');
        },
        onRewarded: () => {
          console.log('Rewarded!');
          myGameInstance.SendMessage('Yandex', 'GetEgle');
          myGameInstance.SendMessage('Yandex', 'getTimeScale');
        },
        onClose: () => {
          console.log('Video ad closed.');
          myGameInstance.SendMessage('Yandex', 'getTimeScale');
        }, 
        onError: (e) => {
          console.log('Error while open video ad:', e);
        }
    }
    })   
  },

  ADSRewardMachete: function () {
    ysdk.adv.showRewardedVideo({
    callbacks: {
        onOpen: () => {
          console.log('Video ad open.');
        },
        onRewarded: () => {
          console.log('Rewarded!');
          myGameInstance.SendMessage('Yandex', 'GetМachete');
          myGameInstance.SendMessage('Yandex', 'getTimeScale');
        },
        onClose: () => {
          console.log('Video ad closed.');
          myGameInstance.SendMessage('Yandex', 'getTimeScale');
        }, 
        onError: (e) => {
          console.log('Error while open video ad:', e);
        }
    }
    })   
  },

  ADSRewardM249: function () {
    ysdk.adv.showRewardedVideo({
    callbacks: {
        onOpen: () => {
          console.log('Video ad open.');
        },
        onRewarded: () => {
          console.log('Rewarded!');
          myGameInstance.SendMessage('Yandex', 'GetM249');
          myGameInstance.SendMessage('Yandex', 'getTimeScale');
        },
        onClose: () => {
          console.log('Video ad closed.');
          myGameInstance.SendMessage('Yandex', 'getTimeScale');
        }, 
        onError: (e) => {
          console.log('Error while open video ad:', e);
        }
    }
    })   
  },

  ADSRewardInfiniteAmmo: function () {
    ysdk.adv.showRewardedVideo({
    callbacks: {
        onOpen: () => {
          console.log('Video ad open.');
        },
        onRewarded: () => {
          console.log('Rewarded!');
          myGameInstance.SendMessage('Yandex', 'GetInfiniteAmmo');
          myGameInstance.SendMessage('Yandex', 'getTimeScale');
        },
        onClose: () => {
          console.log('Video ad closed.');
          myGameInstance.SendMessage('Yandex', 'getTimeScale');
        }, 
        onError: (e) => {
          console.log('Error while open video ad:', e);
        }
    }
    })   
  },


  RateGame: function () {
    console.log(ysdk.feedback.canReview());
    ysdk.feedback.canReview()
        .then(({ value, reason }) => {
            if (value) {
                console.log(ysdk.feedback.requestReview());
                ysdk.feedback.requestReview()
                    .then(({ feedbackSent }) => {
                        console.log(feedbackSent);
                        myGameInstance.SendMessage('Yandex', 'getTimeScale');
                    })
            } else {
                myGameInstance.SendMessage('Yandex', 'getTimeScale');
                console.log(reason);
            }
        })
  },

  Advertising: function () {
    ysdk.adv.showFullscreenAdv({
    callbacks: {
        onClose: function(wasShown) {
          // some action after close
        },
        onError: function(error) {
          // some action on error
            }
        }
    })
  },

});