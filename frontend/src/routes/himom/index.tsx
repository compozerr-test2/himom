import React from "react"
import { createFileRoute } from '@tanstack/react-router'
import HimomComponent from '../../himom-component'

export const Route = createFileRoute('/himom/')({
  component: RouteComponent,
})

function RouteComponent() {
  return (
    <div>
      <HimomComponent name="World!" />
    </div>
  )
}
