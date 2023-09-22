// MADE BY ORXIFY
handlers.changePlayerName = function (args, context) {
    var PlayFabId = context.playerProfile.PlayerId;
    r
    var newName = args.newName;

    var updateResult = server.UpdateUserTitleDisplayName({
        PlayFabId: PlayFabId,
        DisplayName: newName
    });

    return { displayName: updateResult.DisplayName };
};