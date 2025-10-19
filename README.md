# Flex Active Controllers

Пакет `com.unimixstudio.flexactive` содержит набор MonoBehaviour-компонентов для управления активным состоянием объектов и анимаций на DOTween. Его можно использовать для включения/выключения объектов, поведения и композитных последовательностей твинов.

## Установка

### Через Unity Package Manager

1. Откройте *Window ▸ Package Manager*.
2. Нажмите **+** → *Add package from git URL...*.
3. Вставьте `https://github.com/UnimixStudio/flexactive-upm.git#v1.0.0` и подтвердите.

> ⚠️ Пакет требует установленного [DOTween](http://dotween.demigiant.com/) (включая базовый assembly `DG.Tweening`).

### Локальная разработка

- Добавьте строку в `Packages/manifest.json` проекта:
  ```json
  "com.unimixstudio.flexactive": "file:com.unimixstudio.flexactive"
  ```
- После правок обновите `package.json` (версия, описание) и `CHANGELOG.md`, создайте новый git-тег (`vX.Y.Z`).

## Содержимое

- `GameObjectActiveStateController` — переключает `gameObject.SetActive`.
- `BehaviourActiveStateController<T>` — включает/выключает `Behaviour.enabled`.
- `CompositeActiveStateController` — групповой контроллер нескольких активаторов.
- `TweenActiveStateController` и производные — управляют DOTween-анимациями, поддерживают последовательное или параллельное проигрывание (`SequenceTweenController`, `ParallelTweenController`, `CompositeTweenController`).

## Использование

Добавьте нужный контроллер на объект и вызывайте `SetActive(true/false)` из вашего кода, UnityEvents или анимационных клипов. Для твинов переопределите `CreateTween()` и соберите собственную последовательность DOTween действий.

## Лицензия

MIT — подробности см. в [`LICENSE.md`](./LICENSE.md).
