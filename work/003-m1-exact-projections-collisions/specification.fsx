#r "nuget: FS.GG.SDD.Artifacts, 1.5.0"

open FS.GG.SDD.Artifacts.TypedSpecifications

let normalizedSpecificationJson = """{
  "schema": "fsgg.typed-specification/v1",
  "schemaVersion": 1,
  "identity": "SPEC-001",
  "provenance": {
    "agent": "codex",
    "session": "m1-exact-projections-collisions-20260831-01",
    "sourcePath": "work/003-m1-exact-projections-collisions/specification.fsx",
    "sourceRevision": "0000000000000000000000000000000000000000000000000000000000000000",
    "authoredAtUtc": "2026-08-31T09:59:07.3724626\u002B00:00"
  },
  "intent": "Promote the fifteen exact M1 Babylon.js projections and module-qualified collisions without lossy fallbacks",
  "evidenceObligations": [
    {
      "id": "EV001",
      "kind": "test",
      "description": "Compile exported/support alias assignments and every constituent member of the glTF intersections."
    },
    {
      "id": "EV002",
      "kind": "test",
      "description": "Fable-compile representative correlated calls and inspect exact emitted runtime imports."
    },
    {
      "id": "EV003",
      "kind": "test",
      "description": "Run Node smoke for typed-array correlation, deepMerge, glTF mapping, and both physics module exports."
    },
    {
      "id": "EV004",
      "kind": "verification",
      "description": "Regenerate deterministic manifests and prove exact structural equality against Babylon.js 9.19.0 declarations."
    },
    {
      "id": "EV005",
      "kind": "verification",
      "description": "Regenerate coverage and prove exactly 4,252 typed, 70 blocked, one runtime-only, and zero lossy exports."
    },
    {
      "id": "EV006",
      "kind": "test",
      "description": "Pack and consume the maintained binding from a clean external project with exact npm dependencies."
    }
  ],
  "extensionKind": "requirements",
  "extensionSchemaVersion": 1,
  "extension": {
    "schema": "fsgg.requirements-extension/v1",
    "schemaVersion": 1,
    "userValue": "Fable consumers can use fifteen previously blocked Babylon.js exports with exact compile-time shape, runtime module identity, and discriminator/return correlation.",
    "scope": [
      {
        "id": "SB-001",
        "statement": "Close only the six camera input aliases, TypedArrayConstructor, CreateAlignedTypedArray, the v1/v2 PhysicsEngine collision pair, GLTFLoaderOptions, both glTF object-model tree interfaces, GetMappingForKey, and deepMerge."
      },
      {
        "id": "SB-002",
        "statement": "Preserve the locked Babylon.js 9.19.0 declaration closure, exact deep imports, type-only/runtime boundaries, intersections as both-member shapes, and obj only where upstream any defaults authorize it."
      }
    ],
    "nonGoals": [
      {
        "id": "SB-003",
        "statement": "Closing M2 through M6 exports, changing package/toolchain pins, or accepting generated candidates without review."
      },
      {
        "id": "SB-004",
        "statement": "Using U2 for intersections, broad uncorrelated typed-array returns, fictitious runtime imports for type-only exports, or merging physics identities."
      }
    ],
    "stories": [
      {
        "id": "US-001",
        "priority": "P1",
        "statement": "A Fable consumer can compile against the promoted aliases and exact structural glTF projections."
      },
      {
        "id": "US-002",
        "priority": "P1",
        "statement": "A Fable consumer can call runtime functions and collision-qualified physics classes through exact deep modules."
      },
      {
        "id": "US-003",
        "priority": "P1",
        "statement": "A maintainer can deterministically prove structural fidelity, import identity, coverage totals, and clean package consumption."
      }
    ],
    "requirements": [
      {
        "id": "FR-001",
        "statement": "The maintained surface MUST promote the six camera aliases and GLTFLoaderOptions as type-only aliases whose reviewed structures exactly match their existing support projections.",
        "acceptanceIds": [
          "AC-001"
        ],
        "evidenceObligationIds": [
          "EV001",
          "EV004"
        ]
      },
      {
        "id": "FR-002",
        "statement": "The maintained surface MUST model IGLTFObjectModelTreeNodesObject and IGLTFObjectModelTree with named interfaces exposing every constituent member of each upstream intersection and MUST NOT substitute U2 or unauthorized obj.",
        "acceptanceIds": [
          "AC-002"
        ],
        "evidenceObligationIds": [
          "EV001",
          "EV004"
        ]
      },
      {
        "id": "FR-003",
        "statement": "CreateAlignedTypedArray MUST preserve constructor-to-return correlation for every locked typed-array alternative, while GetMappingForKey and deepMerge MUST preserve their exact authorized generic/object contracts.",
        "acceptanceIds": [
          "AC-003"
        ],
        "evidenceObligationIds": [
          "EV002",
          "EV003",
          "EV004"
        ]
      },
      {
        "id": "FR-004",
        "statement": "The two PhysicsEngine exports MUST remain distinct as PhysicsEngineV1 and PhysicsEngineV2 and import runtime export PhysicsEngine from their exact v1 and v2 deep modules.",
        "acceptanceIds": [
          "AC-004"
        ],
        "evidenceObligationIds": [
          "EV002",
          "EV003",
          "EV004"
        ]
      },
      {
        "id": "FR-005",
        "statement": "M1 MUST close exactly fifteen exports and coverage MUST report exactly 4,252 typed, 70 blocked, one runtime-only, and zero lossy exports with deterministic reviewed manifests.",
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
        "statement": "The maintained library MUST compile, Fable-emit, pass exact import checks and Node smoke, and install and execute from a clean packed consumer.",
        "acceptanceIds": [
          "AC-006"
        ],
        "evidenceObligationIds": [
          "EV002",
          "EV003",
          "EV006"
        ]
      }
    ],
    "acceptance": [
      {
        "id": "AC-001",
        "storyIds": [
          "US-001"
        ],
        "requirementIds": [
          "FR-001"
        ],
        "statement": "Given the exported aliases and support projections, compile assignments work in both directions and structural digests match the locked declarations."
      },
      {
        "id": "AC-002",
        "storyIds": [
          "US-001"
        ],
        "requirementIds": [
          "FR-002"
        ],
        "statement": "Given one glTF tree value, compile fixtures access every member from all intersection constituents and no U2 or unauthorized obj appears in the projection."
      },
      {
        "id": "AC-003",
        "storyIds": [
          "US-002"
        ],
        "requirementIds": [
          "FR-003"
        ],
        "statement": "Given each supported typed-array constructor, the aligned factory returns its matching array type, while deepMerge and glTF mapping execute with their exact contracts."
      },
      {
        "id": "AC-004",
        "storyIds": [
          "US-002"
        ],
        "requirementIds": [
          "FR-004"
        ],
        "statement": "Given emitted and dynamic imports, both collision-qualified physics bindings resolve distinct exact deep modules whose runtime export is PhysicsEngine."
      },
      {
        "id": "AC-005",
        "storyIds": [
          "US-003"
        ],
        "requirementIds": [
          "FR-005"
        ],
        "statement": "Given regenerated coverage, totals equal 4,252 typed, 70 blocked, one runtime-only, and zero lossy, and exactly the fifteen named exports changed disposition."
      },
      {
        "id": "AC-006",
        "storyIds": [
          "US-003"
        ],
        "requirementIds": [
          "FR-006"
        ],
        "statement": "Given locked restores and an external clean consumer, maintained .NET/Fable compilation, import checks, Node smoke, packing, installation, and execution all pass."
      }
    ],
    "ambiguities": [],
    "publicImpact": [
      "Adds fifteen exact maintained exports to the BabylonjsBindings public Fable surface without changing upstream or toolchain pins."
    ],
    "lifecycleNotes": [
      "Generated candidates are review-only; the maintained fragments and manifests are the accepted authority.",
      "Roadmap milestone M1 is non-game work and leaves M2 through M6 unchecked."
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
