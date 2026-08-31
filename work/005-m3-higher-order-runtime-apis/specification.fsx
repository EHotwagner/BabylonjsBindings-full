#r "nuget: FS.GG.SDD.Artifacts, 1.5.0"

open FS.GG.SDD.Artifacts.TypedSpecifications

let normalizedSpecificationJson = """{
  "schema": "fsgg.typed-specification/v1",
  "schemaVersion": 1,
  "identity": "SPEC-001",
  "provenance": {
    "agent": "m3-higher-order-runtime-apis-20260831t090000z",
    "session": "m3-repair-round-1",
    "sourcePath": "work/005-m3-higher-order-runtime-apis/specification.fsx",
    "sourceRevision": "0000000000000000000000000000000000000000000000000000000000000000",
    "authoredAtUtc": "2026-08-31T15:52:47.5308669\u002B00:00"
  },
  "intent": "Close exactly eight M3 higher-order runtime exports with evidence-derived callable arities and exact decorator and mixin correlations",
  "evidenceObligations": [
    {
      "id": "EV001",
      "kind": "verification",
      "description": "Digest-check and scan all 2,928 locked declarations, proving fixed callback arity 10 and recording fixed-callable arity 17 as context."
    },
    {
      "id": "EV002",
      "kind": "test",
      "description": "Compile positive arity 0 through 10 calls and reject wrong-arity, parameter, this, result, and broad-projection fixtures."
    },
    {
      "id": "EV003",
      "kind": "test",
      "description": "Fable-compile representative coroutine and decorator calls, inspect emitted JavaScript call and this semantics, and execute Node proof."
    },
    {
      "id": "EV004",
      "kind": "test",
      "description": "Compile and execute named both-member ImageProcessing, ImageProcessingDefines, and UV mixin specializations without U2 or unconstrained obj."
    },
    {
      "id": "EV005",
      "kind": "test",
      "description": "Execute applicable Chromium runtime and import proof for decorator and mixin modules."
    },
    {
      "id": "EV006",
      "kind": "test",
      "description": "Aggregate positive, negative, emitted JavaScript, Node, and Chromium checks into one observed non-synthetic test receipt."
    },
    {
      "id": "EV007",
      "kind": "verification",
      "description": "Regenerate coverage and prove exactly 4,287 typed, 35 blocked, one runtime-only, and zero lossy with exactly eight exports reclassified."
    },
    {
      "id": "EV008",
      "kind": "test",
      "description": "Pack and consume version 0.1.4 in a clean project with exact npm dependencies, emitted imports, Node, and Chromium proof."
    }
  ],
  "extensionKind": "requirements",
  "extensionSchemaVersion": 1,
  "extension": {
    "schema": "fsgg.requirements-extension/v1",
    "schemaVersion": 1,
    "userValue": "Fable consumers can use Babylon.js coroutine adapters, decorators, native override filtering, and material mixins without losing parameter, this, context/result, or intersection correlations.",
    "scope": [
      {
        "id": "SB-001",
        "statement": "Close exactly makeSyncFunction, makeAsyncFunction, addAccessorsForMaterialProperty, expandToProperty, nativeOverride, ImageProcessingMixin, ImageProcessingDefinesMixin, and UVDefinesMixin from Babylon.js 9.19.0."
      },
      {
        "id": "SB-002",
        "statement": "Adopt stable callable families for arities 0 through 10 from the digest-verified 2,928-file callback scan; record broader fixed-callable arity 17 only as context."
      }
    ],
    "nonGoals": [
      {
        "id": "SB-003",
        "statement": "Closing M4 through M6 exports, changing Babylon.js or toolchain pins, or changing game functionality."
      },
      {
        "id": "SB-004",
        "statement": "Using ParamArray obj, U2 intersections, unconstrained obj mixin results, fictitious imports, or generated candidates as maintained authority."
      }
    ],
    "stories": [
      {
        "id": "US-001",
        "priority": "P1",
        "statement": "A consumer wraps heterogeneous coroutine factories of every locked callback arity while preserving each argument and result type."
      },
      {
        "id": "US-002",
        "priority": "P1",
        "statement": "A consumer applies accessor and method decorators with exact context, result, explicit JavaScript this, and callable nativeOverride.filter behavior."
      },
      {
        "id": "US-003",
        "priority": "P1",
        "statement": "A consumer applies each material mixin and receives one named result exposing both exact base members and all added members."
      },
      {
        "id": "US-004",
        "priority": "P1",
        "statement": "A maintainer proves arity, rejection, emitted calls, runtime behavior, coverage, and clean packed consumption."
      }
    ],
    "requirements": [
      {
        "id": "FR-001",
        "statement": "The repository MUST scan and digest-check all 2,928 locked declarations, reject provisional arities 0 through 8, adopt stable callable families 0 through 10, and record fixed-callable declaration arity 17 only as context.",
        "acceptanceIds": [
          "AC-001"
        ],
        "evidenceObligationIds": [
          "EV001"
        ]
      },
      {
        "id": "FR-002",
        "statement": "makeSyncFunction and makeAsyncFunction MUST preserve heterogeneous parameter and return correlations for arities 0 through 10 without ParamArray obj erasure.",
        "acceptanceIds": [
          "AC-002"
        ],
        "evidenceObligationIds": [
          "EV001",
          "EV002",
          "EV003"
        ]
      },
      {
        "id": "FR-003",
        "statement": "expandToProperty and addAccessorsForMaterialProperty MUST preserve exact ClassAccessorDecoratorTarget, ClassAccessorDecoratorContext, and ClassAccessorDecoratorResult correlations and Nullable source-key semantics.",
        "acceptanceIds": [
          "AC-003"
        ],
        "evidenceObligationIds": [
          "EV002",
          "EV003"
        ]
      },
      {
        "id": "FR-004",
        "statement": "nativeOverride MUST be callable with callable filter, preserve explicit JavaScript this and heterogeneous arities 0 through 10, and emit exact decorator calls.",
        "acceptanceIds": [
          "AC-004"
        ],
        "evidenceObligationIds": [
          "EV002",
          "EV003"
        ]
      },
      {
        "id": "FR-005",
        "statement": "Each material mixin MUST return named both-member interfaces and exact specializations for every locked concrete base use, never U2 or unconstrained obj.",
        "acceptanceIds": [
          "AC-005"
        ],
        "evidenceObligationIds": [
          "EV004",
          "EV005"
        ]
      },
      {
        "id": "FR-006",
        "statement": "Positive and negative compile fixtures, emitted JavaScript inspection, Node, and Chromium MUST prove coroutine, decorator, filter, this, and mixin behavior.",
        "acceptanceIds": [
          "AC-006"
        ],
        "evidenceObligationIds": [
          "EV002",
          "EV003",
          "EV004",
          "EV005"
        ]
      },
      {
        "id": "FR-007",
        "statement": "M3 MUST close exactly eight exports and coverage MUST report exactly 4,287 typed, 35 blocked, one runtime-only, and zero lossy.",
        "acceptanceIds": [
          "AC-007"
        ],
        "evidenceObligationIds": [
          "EV001",
          "EV007"
        ]
      },
      {
        "id": "FR-008",
        "statement": "The maintained package MUST compile, pack at version 0.1.4, install into a clean consumer, resolve exact npm imports, and execute Node and Chromium proof.",
        "acceptanceIds": [
          "AC-008"
        ],
        "evidenceObligationIds": [
          "EV003",
          "EV005",
          "EV008"
        ]
      }
    ],
    "acceptance": [
      {
        "id": "AC-001",
        "storyIds": [
          "US-004"
        ],
        "requirementIds": [
          "FR-001"
        ],
        "statement": "Given declaration-lock.json, the scan verifies 2,928 hashes, reports callback maximum 10 and fixed-callable maximum 17, and adopts 0 through 10."
      },
      {
        "id": "AC-002",
        "storyIds": [
          "US-001"
        ],
        "requirementIds": [
          "FR-002"
        ],
        "statement": "Given factories at arities 0 through 10, arguments and sync or Promise results stay correlated while wrong fixtures fail."
      },
      {
        "id": "AC-003",
        "storyIds": [
          "US-002"
        ],
        "requirementIds": [
          "FR-003"
        ],
        "statement": "Given accessor target and context, both factories return the exact result and preserve null versus undefined keys in emitted calls."
      },
      {
        "id": "AC-004",
        "storyIds": [
          "US-002"
        ],
        "requirementIds": [
          "FR-004"
        ],
        "statement": "Given method and context, nativeOverride and filter remain callable, preserve this and all argument/result types, and execute the expected branch."
      },
      {
        "id": "AC-005",
        "storyIds": [
          "US-003"
        ],
        "requirementIds": [
          "FR-005"
        ],
        "statement": "Given every locked concrete material base, one named mixed result exposes base and added members and runtime construction succeeds."
      },
      {
        "id": "AC-006",
        "storyIds": [
          "US-001",
          "US-002",
          "US-003",
          "US-004"
        ],
        "requirementIds": [
          "FR-006"
        ],
        "statement": "Given the M3 matrix, positive, negative, emitted JavaScript, Node, and Chromium lanes pass."
      },
      {
        "id": "AC-007",
        "storyIds": [
          "US-004"
        ],
        "requirementIds": [
          "FR-007"
        ],
        "statement": "Given regenerated coverage, exactly eight M3 identities move to typed and totals are 4,287, 35, one, and zero."
      },
      {
        "id": "AC-008",
        "storyIds": [
          "US-004"
        ],
        "requirementIds": [
          "FR-008"
        ],
        "statement": "Given a clean consumer of 0.1.4 and exact npm packages, Fable emission, imports, Node, and Chromium pass."
      }
    ],
    "ambiguities": [],
    "publicImpact": [
      "Adds eight maintained higher-order exports plus stable arity-indexed callable and named mixin-specialization surfaces.",
      "Extends the provisional arity ladder from 0 through 8 to evidence-derived 0 through 10 without renaming existing families."
    ],
    "lifecycleNotes": [
      "Generated candidates remain review-only; maintained projections are reviewed against locked declarations.",
      "M3 is non-game work and leaves M4 through M6 unchecked."
    ]
  }
}
"""

let model =
    match SpecificationCodec.deserialize RequirementsExtension.contract normalizedSpecificationJson with
    | Ok value -> value
    | Error diagnostics -> failwithf "Invalid Typed SDD authority: %A" diagnostics

let compiled =
    match SpecificationCompiler.compile RequirementsExtension.contract model with
    | Ok value -> value
    | Error diagnostics -> failwithf "Typed SDD compilation failed: %A" diagnostics

printfn "%s" compiled.Fingerprint
