#r "nuget: FS.GG.SDD.Artifacts, 1.5.0"

open FS.GG.SDD.Artifacts.TypedSpecifications

let normalizedSpecificationJson = """{
  "schema": "fsgg.typed-specification/v1",
  "schemaVersion": 1,
  "identity": "SPEC-001",
  "provenance": {
    "agent": "codex",
    "session": "m0-analysis-infrastructure-20260831T080504Z-93487",
    "sourcePath": "work/002-m0-analysis-infrastructure/specification.fsx",
    "sourceRevision": "0000000000000000000000000000000000000000000000000000000000000000",
    "authoredAtUtc": "2026-08-31T08:12:39.2783147\u002B00:00"
  },
  "intent": "Deterministic analysis infrastructure for the remaining Babylon.js exports",
  "evidenceObligations": [
    {
      "id": "EV001",
      "kind": "test",
      "description": "Generate and validate normalized blocked-family diagnostics twice with byte-identical results."
    },
    {
      "id": "EV002",
      "kind": "test",
      "description": "Exercise dependent-map completeness with passing and missing-key fixtures."
    },
    {
      "id": "EV003",
      "kind": "test",
      "description": "Validate the versioned instantiation registry and reject malformed or duplicate entries."
    },
    {
      "id": "EV004",
      "kind": "verification",
      "description": "Verify maintained API files and coverage dispositions remain unchanged at 4,237 typed exports."
    }
  ],
  "extensionKind": "requirements",
  "extensionSchemaVersion": 1,
  "extension": {
    "schema": "fsgg.requirements-extension/v1",
    "schemaVersion": 1,
    "userValue": "Binding maintainers can see deterministic, machine-readable reasons and dependency obligations for every remaining export family before promoting any public API.",
    "scope": [
      {
        "id": "SB-001",
        "statement": "Add analysis-only generators, schemas, reports, fixtures, and tests for the pinned Babylon.js 9.19.0 declaration closure."
      },
      {
        "id": "SB-002",
        "statement": "Preserve all maintained F# sources, reviewed coverage manifests, package pins, and export dispositions."
      }
    ],
    "nonGoals": [
      {
        "id": "SB-003",
        "statement": "Promoting any blocked export to typed or adding any maintained binding API."
      },
      {
        "id": "SB-004",
        "statement": "Implementing the later roadmap families or publishing a NuGet package."
      }
    ],
    "stories": [
      {
        "id": "US-001",
        "priority": "P1",
        "statement": "A binding maintainer can group all 85 blocked exports by normalized family and inspect stable reasons and identities."
      },
      {
        "id": "US-002",
        "priority": "P1",
        "statement": "A generator author can fail early when a finite dependent map omits, adds, or duplicates a discriminator mapping."
      },
      {
        "id": "US-003",
        "priority": "P1",
        "statement": "A binding author can record exact closed-world type-function instantiations in a validated, deterministic registry."
      }
    ],
    "requirements": [
      {
        "id": "FR-001",
        "statement": "The analysis generator MUST classify every blocked export into one normalized family with stable declaration identity and reason data and MUST emit byte-identical output for identical locked inputs.",
        "acceptanceIds": [
          "AC-001"
        ],
        "evidenceObligationIds": [
          "EV001"
        ]
      },
      {
        "id": "FR-002",
        "statement": "The dependent-map completeness checker MUST compare declared discriminator keys with mapped keys and MUST reject missing, extra, or duplicate mappings deterministically.",
        "acceptanceIds": [
          "AC-002"
        ],
        "evidenceObligationIds": [
          "EV002"
        ]
      },
      {
        "id": "FR-003",
        "statement": "The instantiation registry MUST have a versioned machine-readable schema, normalized TypeScript expressions, unique declaration identities, deterministic ordering, and explicit reviewed projection status.",
        "acceptanceIds": [
          "AC-003"
        ],
        "evidenceObligationIds": [
          "EV003"
        ]
      },
      {
        "id": "FR-004",
        "statement": "M0 MUST close zero exports, preserve the maintained public API, and retain exactly 4,237 typed, 85 blocked, one runtime-only, and zero lossy exports.",
        "acceptanceIds": [
          "AC-004"
        ],
        "evidenceObligationIds": [
          "EV004"
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
        "statement": "Given the pinned declaration lock and coverage report, two analysis generations are byte-identical and account for all 85 blocked exports exactly once."
      },
      {
        "id": "AC-002",
        "storyIds": [
          "US-002"
        ],
        "requirementIds": [
          "FR-002"
        ],
        "statement": "Given complete, missing-key, extra-key, and duplicate-key fixtures, only the complete dependent map passes and each failure reports sorted actionable keys."
      },
      {
        "id": "AC-003",
        "storyIds": [
          "US-003"
        ],
        "requirementIds": [
          "FR-003"
        ],
        "statement": "Given the committed empty M0 registry and malformed fixtures, the registry validates deterministically while invalid schema, duplicate identity, and non-normalized expression inputs fail."
      },
      {
        "id": "AC-004",
        "storyIds": [
          "US-001",
          "US-002",
          "US-003"
        ],
        "requirementIds": [
          "FR-004"
        ],
        "statement": "Given the M0 diff and regenerated coverage, maintained F# API and reviewed manifests are unchanged and the typed total remains 4,237."
      }
    ],
    "ambiguities": [],
    "publicImpact": [
      "Adds versioned analysis report and registry contracts plus generator/check commands; no maintained binding API changes."
    ],
    "lifecycleNotes": [
      "Later milestones consume these analysis contracts; M0 does not promote generated candidates.",
      "Roadmap milestone M0 closes zero exports and is non-game work."
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
