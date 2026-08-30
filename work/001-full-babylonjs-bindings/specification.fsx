#r "nuget: FS.GG.SDD.Artifacts, 1.5.0"

open FS.GG.SDD.Artifacts.TypedSpecifications

let normalizedSpecificationJson = """{
  "schema": "fsgg.typed-specification/v1",
  "schemaVersion": 1,
  "identity": "SPEC-001",
  "provenance": {
    "agent": "codex",
    "session": "codex-20260830-full-bindings",
    "sourcePath": "work/001-full-babylonjs-bindings/specification.fsx",
    "sourceRevision": "0000000000000000000000000000000000000000000000000000000000000000",
    "authoredAtUtc": "2026-08-30T10:58:11.7685587\u002B00:00"
  },
  "intent": "Full Babylon.js Fable bindings",
  "evidenceObligations": [
    {
      "id": "EV001",
      "kind": "test",
      "description": "Compile the maintained F# binding and its clean consumer with the pinned toolchain."
    },
    {
      "id": "EV002",
      "kind": "test",
      "description": "Fable-compile representative calls and verify every emitted Babylon import resolves."
    },
    {
      "id": "EV003",
      "kind": "test",
      "description": "Run representative engine, scene, maths, mesh, material, animation, loader, and browser behavior."
    },
    {
      "id": "EV004",
      "kind": "verification",
      "description": "Verify deterministic declaration and generator locks against the exact Babylon 9.19.0 corpus."
    },
    {
      "id": "EV005",
      "kind": "verification",
      "description": "Verify machine-readable export coverage and unsupported-construct accounting."
    },
    {
      "id": "EV006",
      "kind": "test",
      "description": "Pack the NuGet library and exercise it from a clean Fable consumer with exact npm runtime dependencies."
    }
  ],
  "extensionKind": "requirements",
  "extensionSchemaVersion": 1,
  "extension": {
    "schema": "fsgg.requirements-extension/v1",
    "schemaVersion": 1,
    "userValue": "F# and Fable consumers can use the complete exported Babylon.js core and loader API at the pinned version without dropping to dynamic interop for uncovered subsystems.",
    "scope": [
      {
        "id": "SB-001",
        "statement": "Cover the complete exported declaration surface of @babylonjs/core@9.19.0 and @babylonjs/loaders@9.19.0."
      },
      {
        "id": "SB-002",
        "statement": "Generate review-only candidates from exact locked inputs, then maintain an explicit compile-clean F# public surface."
      },
      {
        "id": "SB-003",
        "statement": "Use modular deep imports and verify representative browser and Node execution plus clean consumer packaging."
      }
    ],
    "nonGoals": [
      {
        "id": "SB-004",
        "statement": "Binding Babylon.js packages other than core and loaders, including GUI, materials library, serializers, and inspector."
      },
      {
        "id": "SB-005",
        "statement": "Counting dynamic obj escape hatches or unreviewed generator output as typed coverage."
      },
      {
        "id": "SB-006",
        "statement": "Publishing to NuGet or activating a registry entry as part of this work item."
      }
    ],
    "stories": [
      {
        "id": "US-001",
        "priority": "P1",
        "statement": "A Fable application author can discover and call Babylon core and loader APIs through compile-time checked F# bindings."
      },
      {
        "id": "US-002",
        "priority": "P1",
        "statement": "A binding maintainer can reproduce the candidate and see exact declaration, coverage, import, or unsupported-syntax drift before release."
      }
    ],
    "requirements": [
      {
        "id": "FR-001",
        "statement": "The declaration lock MUST start from the package index entry points and include every reachable declaration in @babylonjs/core@9.19.0 and @babylonjs/loaders@9.19.0.",
        "acceptanceIds": [
          "AC-001"
        ],
        "evidenceObligationIds": [
          "EV004"
        ]
      },
      {
        "id": "FR-002",
        "statement": "Candidate generation MUST be deterministic, tool-version locked, review-only, and MUST NOT overwrite maintained binding source.",
        "acceptanceIds": [
          "AC-002"
        ],
        "evidenceObligationIds": [
          "EV004"
        ]
      },
      {
        "id": "FR-003",
        "statement": "The maintained F# surface MUST compile and expose typed declarations for every supported export; dynamic obj escape hatches MUST NOT count as typed coverage.",
        "acceptanceIds": [
          "AC-003"
        ],
        "evidenceObligationIds": [
          "EV001",
          "EV005"
        ]
      },
      {
        "id": "FR-004",
        "statement": "Every emitted Babylon import MUST resolve to the exact modular npm runtime and remain tree-shakeable; loader registration MUST use explicit side effects.",
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
        "statement": "Unsupported or lossy TypeScript constructs MUST be identified by source location and reason in a machine-readable report and MUST block a claim of complete typed coverage.",
        "acceptanceIds": [
          "AC-005"
        ],
        "evidenceObligationIds": [
          "EV005"
        ]
      },
      {
        "id": "FR-006",
        "statement": "The release candidate MUST pass compile, emitted-import, representative Node and real-browser runtime, package, and clean-consumer verification.",
        "acceptanceIds": [
          "AC-006"
        ],
        "evidenceObligationIds": [
          "EV001",
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
          "US-002"
        ],
        "requirementIds": [
          "FR-001"
        ],
        "statement": "Given a clean npm install, regenerating the declaration lock from both package index entry points yields no drift and reports the complete reachable file count."
      },
      {
        "id": "AC-002",
        "storyIds": [
          "US-002"
        ],
        "requirementIds": [
          "FR-002"
        ],
        "statement": "Given identical locked inputs and tools, two candidate runs are byte-identical and leave maintained source and the declaration lock unchanged."
      },
      {
        "id": "AC-003",
        "storyIds": [
          "US-001",
          "US-002"
        ],
        "requirementIds": [
          "FR-003"
        ],
        "statement": "Given the export inventory, each export is classified as typed, intentionally runtime-only, or blocked with a reason; all typed entries compile in the maintained library."
      },
      {
        "id": "AC-004",
        "storyIds": [
          "US-001"
        ],
        "requirementIds": [
          "FR-004"
        ],
        "statement": "Given representative F# calls, Fable output contains only resolvable @babylonjs/core or @babylonjs/loaders deep imports and explicit loader side effects."
      },
      {
        "id": "AC-005",
        "storyIds": [
          "US-002"
        ],
        "requirementIds": [
          "FR-005"
        ],
        "statement": "Given an unsupported construct, generation records its declaration path, syntax category, disposition, and coverage impact and the full-coverage gate fails."
      },
      {
        "id": "AC-006",
        "storyIds": [
          "US-001"
        ],
        "requirementIds": [
          "FR-006"
        ],
        "statement": "Given a packed NuGet artifact and exact npm dependencies in a clean consumer, compilation, import resolution, Node smoke, and real-browser smoke all pass."
      }
    ],
    "ambiguities": [],
    "publicImpact": [],
    "lifecycleNotes": [
      "The monolithic same-version Babylon declaration bundle may be used only as deterministic generator input; modular @babylonjs/core and @babylonjs/loaders declarations and runtime imports remain authoritative.",
      "Tier 1 public-surface expansion; specification, generator locks, maintained source, coverage report, signatures, tests, docs, and package evidence move together."
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
