﻿module CommonEntityUpdater

open UnityEngine

let update (entityData:CommonEntityData.T) (gameObject:GameObject) =
    let x = entityData.position |> fst |> float32
    let y = entityData.position |> snd |> float32
    gameObject.transform.position.x = x
    gameObject.transform.position.y = y
    ()

